using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Text.Json;

namespace NicaCompare
{
    public partial class Inicio : Form
    {
        private void pictureBox2_Click(object sender, EventArgs e) { }
        private void botonMenu1_Click(object sender, EventArgs e) { }
        private void botonMenu6_Click(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void INGRESAR1_Click(object sender, EventArgs e) { }

        private void barraBusqueda1_BuscarClicked(object sender, EventArgs e) { }
        private void Inicio_Load(object sender, EventArgs e) { }
        private void botonMenu2_Click(object sender, EventArgs e) { }
        private void botonMenu2_Click_1(object sender, EventArgs e) { }
        private void botonCategoriaCheck1_Click(object sender, EventArgs e) { }
        private void botonCategoriaCheck3_Click(object sender, EventArgs e) { }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e) { }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e) { }
        private void label1_Click_1(object sender, EventArgs e) { }
        private void label11_Click(object sender, EventArgs e) { }
        private void label_producto_busqueda_Click(object sender, EventArgs e) { }
        private void pictureBox3_Click(object sender, EventArgs e) { }
        public Inicio() { InitializeComponent(); CargarUsuarioActivo(); }

        private void botonMenu6_Click_1(object sender, EventArgs e) { Pantallas.cambiar<Form8>(this); }

        private void CargarUsuarioActivo() { if (GestorSesion.ValidarSesion()) { boton_usuario.Text = sesion_actual.Nombre; } }

        private void boton_usuario_Click(object sender, EventArgs e)
        {
            if (!GestorSesion.ValidarSesion()) { Pantallas.cambiar<Login>(this); }
            else { Pantallas.cambiar<Form6>(this); }
        }

        private void tarjetaTienda1_CheckedChanged(object sender, EventArgs e) { ConfigScraper.Tiendas["el GallomasGallo"]["Activo"] = tarjetaTienda1.Seleccionado ? "SI" : "NO"; }
        private void tarjetaTienda2_CheckedChanged(object sender, EventArgs e) { ConfigScraper.Tiendas["SICSA"]["Activo"] = tarjetaTienda2.Seleccionado ? "SI" : "NO"; }
        private void tarjetaTienda3_CheckedChanged(object sender, EventArgs e) { ConfigScraper.Tiendas["GCM"]["Activo"] = tarjetaTienda3.Seleccionado ? "SI" : "NO"; }

        private void btn_cerar_sesion_Click(object sender, EventArgs e)
        {
            sesion_actual.Correo = "";
            sesion_actual.Nombre = "";
            sesion_actual.TipoUsuario = "";
            sesion_actual.Saldo = 0;
            sesion_actual.Telefono = 0;
            sesion_actual.fecha_registro = DateTime.Today;
            Pantallas.cambiar<Login>(this);
        }

        private async void barraBusqueda1_BuscarClicked_1(object sender, EventArgs e)
        {
            string textoBuscado = barraBusqueda1.Text;
            if (string.IsNullOrWhiteSpace(textoBuscado)) { return; }

            //TABLAPRODUCTOS.Rows.Clear();
            //if (Grid_Compare != null) { Grid_Compare.Rows.Clear(); }
            label_producto_busqueda.Text = $"Buscando: {textoBuscado} por favor espere";
            barraBusqueda1.Text = "";

            await EmpezarBusqueda(textoBuscado);
        }

        private void AgregarProductoATabla(string nombre, string precio, string tiendaKey)
        {
            string nomImg = ConfigScraper.Tiendas[tiendaKey].ContainsKey("img") ? ConfigScraper.Tiendas[tiendaKey]["img"].Replace("Properties.Resources.", "") : "";
            var imgObjeto = !string.IsNullOrEmpty(nomImg) ? Properties.Resources.ResourceManager.GetObject(nomImg) : null;
            Image logo = imgObjeto != null ? (Image)imgObjeto : Properties.Resources.LOGO_22;
            //TABLAPRODUCTOS.Rows.Add(nombre, precio, logo, tiendaKey);
        }

        private void AgregarMejorProductoATabla(string nombre, string precio, string tiendaKey)
        {
            string nomImg = ConfigScraper.Tiendas[tiendaKey].ContainsKey("img") ? ConfigScraper.Tiendas[tiendaKey]["img"].Replace("Properties.Resources.", "") : "";
            var imgObjeto = !string.IsNullOrEmpty(nomImg) ? Properties.Resources.ResourceManager.GetObject(nomImg) : null;
            Image logo = imgObjeto != null ? (Image)imgObjeto : Properties.Resources.LOGO_22;
            string textoCombinado = string.IsNullOrWhiteSpace(precio) ? nombre : $"{precio} - {nombre}";
           // if (Grid_Compare != null) { Grid_Compare.Rows.Add(logo, textoCombinado); }
        }

        private decimal ParsearPrecio(string precioTexto)
        {
            if (string.IsNullOrWhiteSpace(precioTexto) || precioTexto == "Sin precio") return decimal.MaxValue;
            string limpio = precioTexto.ToUpper()
                .Replace("C$", "")
                .Replace("U$", "")
                .Replace("$", "")
                .Replace(" ", "")
                .Replace("\u00A0", "")
                .Replace(",", "")
                .Replace("+IVA", "")
                .Replace("IVA", "")
                .Trim();
            if (decimal.TryParse(limpio, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out decimal resultado)) { return resultado; }
            return decimal.MaxValue;
        }

        private async Task EmpezarBusqueda(string textoBuscado)
        {
            List<Task<(string, List<ProductoResult>)>> tareasScraping = new List<Task<(string, List<ProductoResult>)>>();
            var handler = new HttpClientHandler
            {
                AllowAutoRedirect = true,
                AutomaticDecompression = System.Net.DecompressionMethods.GZip | System.Net.DecompressionMethods.Deflate | System.Net.DecompressionMethods.Brotli
            };
            using (HttpClient client = new HttpClient(handler))
            {
                foreach (var tienda in ConfigScraper.Tiendas)
                {
                    if (tienda.Value.ContainsKey("Activo") && tienda.Value["Activo"] == "NO") continue;
                    tareasScraping.Add(ScrapearTiendaAsync(client, textoBuscado, tienda));
                }

                var resultadosPorTienda = await Task.WhenAll(tareasScraping);
                int totalEncontrados = 0;
                List<ProductoResult> losMasBaratos = new List<ProductoResult>();
                HashSet<string> productosAgregadosGlobal = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

                foreach (var res in resultadosPorTienda)
                {
                    if (res.Item2.Count > 0)
                    {
                        foreach (var prod in res.Item2)
                        {
                            string claveCache = $"{prod.TiendaKey}_{prod.Nombre}";
                            if (productosAgregadosGlobal.Add(claveCache)) { AgregarProductoATabla(prod.Nombre, prod.PrecioTexto, prod.TiendaKey); totalEncontrados++; }
                        }
                        var masBarato = res.Item2.Where(p => p.PrecioMonto < decimal.MaxValue).OrderBy(p => p.PrecioMonto).FirstOrDefault();
                        if (masBarato != null) { losMasBaratos.Add(masBarato); }
                    }
                    else { losMasBaratos.Add(new ProductoResult { Nombre = "No disponible en esta tienda", PrecioTexto = "", PrecioMonto = decimal.MaxValue, TiendaKey = res.Item1 }); }
                }

                losMasBaratos = losMasBaratos.OrderBy(p => p.PrecioMonto).ToList();
                foreach (var mejor in losMasBaratos) { AgregarMejorProductoATabla(mejor.Nombre, mejor.PrecioTexto, mejor.TiendaKey); }
                label_producto_busqueda.Text = $"Resultados para: {textoBuscado} #{totalEncontrados}";
            }
        }

        private async Task<(string, List<ProductoResult>)> ScrapearTiendaAsync(HttpClient client, string textoBuscado, KeyValuePair<string, Dictionary<string, string>> tienda)
        {
            List<ProductoResult> productosEncontrados = new List<ProductoResult>();
            try
            {
                if (tienda.Value.ContainsKey("Tipo") && tienda.Value["Tipo"] == "Algolia")
                {
                    string urlAlgolia = tienda.Value["Url"];
                    var payload = new { query = textoBuscado, hitsPerPage = 40 };
                    string jsonBody = JsonSerializer.Serialize(payload);
                    using (var req = new HttpRequestMessage(HttpMethod.Post, urlAlgolia))
                    {
                        req.Headers.Add("X-Algolia-Application-Id", tienda.Value["AlgoliaAppId"]);
                        req.Headers.Add("X-Algolia-API-Key", tienda.Value["AlgoliaApiKey"]);
                        req.Content = new StringContent(jsonBody, Encoding.UTF8, "application/json");

                        var resp = await client.SendAsync(req);
                        if (resp.IsSuccessStatusCode)
                        {
                            string jsonRes = await resp.Content.ReadAsStringAsync();
                            using (var doc = JsonDocument.Parse(jsonRes))
                            {
                                if (doc.RootElement.TryGetProperty("hits", out var hits) && hits.ValueKind == JsonValueKind.Array)
                                {
                                    foreach (var hit in hits.EnumerateArray())
                                    {
                                        string nombre = hit.TryGetProperty("name", out var nProp) ? nProp.GetString() ?? "" : "";
                                        string precioTexto = "Sin precio";
                                        decimal precioMonto = decimal.MaxValue;

                                        if (hit.TryGetProperty("price", out var pObj) && pObj.ValueKind == JsonValueKind.Object)
                                        {
                                            if (pObj.TryGetProperty("NIO", out var nio) && nio.ValueKind == JsonValueKind.Object)
                                            {
                                                if (nio.TryGetProperty("default_formated", out var df)) { precioTexto = df.GetString() ?? "Sin precio"; }
                                                if (nio.TryGetProperty("default", out var dv) && dv.TryGetDecimal(out var dec)) { precioMonto = dec; }
                                            }
                                        }

                                        if (!string.IsNullOrEmpty(nombre))
                                        {
                                            if (precioMonto == decimal.MaxValue) precioMonto = ParsearPrecio(precioTexto);
                                            productosEncontrados.Add(new ProductoResult { Nombre = nombre, PrecioTexto = precioTexto, PrecioMonto = precioMonto, TiendaKey = tienda.Key });
                                        }
                                    }
                                }
                            }
                        }
                    }
                    return (tienda.Key, productosEncontrados);
                }

                string textoCodificado = Uri.EscapeDataString(textoBuscado);
                string urlBusqueda = tienda.Value["Url"] + textoCodificado + (tienda.Value.ContainsKey("UrlParametros") ? tienda.Value["UrlParametros"] : "");
                using (var request = new HttpRequestMessage(HttpMethod.Get, urlBusqueda))
                {
                    if (tienda.Value.ContainsKey("UserAgent"))
                    {
                        request.Headers.Add("User-Agent", tienda.Value["UserAgent"]);
                    }
                    var response = await client.SendAsync(request);
                    if (response.IsSuccessStatusCode)
                    {
                        string html = await response.Content.ReadAsStringAsync();
                        HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument(); doc.LoadHtml(html);

                        string xpathContenedor = tienda.Value.ContainsKey("XPathContenedor") ? tienda.Value["XPathContenedor"] : "//*[contains(@class, 'product') and not(contains(@class, 'category'))]";
                        var nodosProductos = doc.DocumentNode.SelectNodes(xpathContenedor);

                        if (nodosProductos != null)
                        {
                            int count = 0;
                            string[] palabrasExcluidas = tienda.Value.ContainsKey("ExcluirNombres") ? tienda.Value["ExcluirNombres"].Split('|') : new string[0];
                            string[] terminosOmitir = { "Añadir al carrito", "Agregar a Lista de deseos", "Leer más" };
                            string xpathTitulo = tienda.Value.ContainsKey("XPathTitulo") ? tienda.Value["XPathTitulo"] : ".//*[contains(@class, 'title') or contains(@class, 'name') or name()='h2' or name()='h3']";
                            string xpathPrecio = tienda.Value.ContainsKey("XPathPrecio") ? tienda.Value["XPathPrecio"] : ".//ins//bdi | .//bdi | .//*[contains(@class, 'electro-price')] | .//*[contains(@class, 'price')]";

                            foreach (var nodo in nodosProductos)
                            {
                                if (count >= 1000) break;
                                var nodoTitulo = nodo.SelectSingleNode(xpathTitulo);
                                var nodoPrecio = nodo.SelectSingleNode(xpathPrecio);
                                string nombre = nodoTitulo != null ? System.Net.WebUtility.HtmlDecode(nodoTitulo.InnerText.Trim()).Replace("\n", " ").Replace("\r", "") : "";
                                string precio = nodoPrecio != null ? System.Net.WebUtility.HtmlDecode(nodoPrecio.InnerText.Trim()).Replace("\n", " ").Replace("\r", "") : "Sin precio";

                                foreach (var term in terminosOmitir) { precio = precio.Replace(term, ""); }
                                precio = precio.Trim();

                                bool esValido = !string.IsNullOrEmpty(nombre);
                                foreach (var palabra in palabrasExcluidas) { if (nombre.Contains(palabra, StringComparison.OrdinalIgnoreCase)) { esValido = false; break; } }
                                if (esValido) { productosEncontrados.Add(new ProductoResult { Nombre = nombre, PrecioTexto = precio, PrecioMonto = ParsearPrecio(precio), TiendaKey = tienda.Key }); count++; }
                            }
                        }
                    }
                }
            }
            catch { }
            return (tienda.Key, productosEncontrados);
        }


    }

    public class ProductoResult
    {
        public string Nombre { get; set; } = "";
        public string PrecioTexto { get; set; } = "";
        public decimal PrecioMonto { get; set; }
        public string TiendaKey { get; set; } = "";
    }
}