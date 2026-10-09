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
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public Inicio() { InitializeComponent(); CargarUsuarioActivo(); }


        private void botonMenu6_Click_1(object sender, EventArgs e) { Pantallas.cambiar<Form8>(this); }
        //____________๑.・🍨︴Boton Usuario ✰  ๑_______________
        private void CargarUsuarioActivo() { if (GestorSesion.ValidarSesion()) { boton_usuario.Text = sesion_actual.Nombre; } }// btn_Usuario_2.Text = sesion_actual.Nombre; } }

        private void boton_usuario_Click(object sender, EventArgs e)
        {
            if (!GestorSesion.ValidarSesion()) { Pantallas.cambiar<Login>(this); }
            else { Pantallas.cambiar<Form6>(this); }
        }

        private void tarjetaTienda1_CheckedChanged(object sender, EventArgs e) { ConfigScraper.Tiendas["La Curacao"]["Activo"] = tarjetaTienda1.Seleccionado ? "SI" : "NO"; }

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

            TABLAPRODUCTOS.Rows.Clear();
            label_producto_busqueda.Text = $"Buscando: {textoBuscado} porfavor espere";
            barraBusqueda1.Text = "";

            await EjecutarScrapingAsync(textoBuscado);
        }

        private void AgregarProductoATabla(string nombre, string precio, string tienda) { TABLAPRODUCTOS.Rows.Add(nombre, precio, tienda); }


        private async Task EjecutarScrapingAsync(string textoBuscado)
        {
            HashSet<string> productosAgregados = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            using (HttpClient client = new HttpClient())
            {
                int encontrados = 0;
                label_producto_busqueda.Text = $"Buscando: {textoBuscado} ⭕";
                foreach (var tienda in ConfigScraper.Tiendas)
                {
                    label_producto_busqueda.Text = label_producto_busqueda.Text + " ⭕";

                    if (tienda.Value.ContainsKey("Activo") && tienda.Value["Activo"] == "NO") continue;

                    string urlBusqueda = tienda.Value["Url"] + textoBuscado + (tienda.Value.ContainsKey("UrlParametros") ? tienda.Value["UrlParametros"] : "");
                    client.DefaultRequestHeaders.Clear();
                    client.DefaultRequestHeaders.Add("User-Agent", tienda.Value["UserAgent"]);

                    try
                    {
                        string html = await client.GetStringAsync(urlBusqueda);
                        HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument(); doc.LoadHtml(html);

                        var nodosProductos = doc.DocumentNode.SelectNodes("//*[contains(@class, 'product') and not(contains(@class, 'category'))]");

                        if (nodosProductos != null)
                        {
                            int count = 0;
                            string[] palabrasExcluidas = tienda.Value.ContainsKey("ExcluirNombres") ? tienda.Value["ExcluirNombres"].Split('|') : new string[0];
                            string[] terminosOmitir = { "Añadir al carrito", "Agregar a Lista de deseos", "Leer más" };

                            foreach (var nodo in nodosProductos)
                            {
                                if (count >= 1000) break;

                                var nodoTitulo = nodo.SelectSingleNode(".//*[contains(@class, 'title') or contains(@class, 'name') or name()='h2' or name()='h3']");
                                var nodoPrecio = nodo.SelectSingleNode(".//ins//bdi | .//bdi | .//*[contains(@class, 'electro-price')] | .//*[contains(@class, 'price')]");

                                string nombre = nodoTitulo != null ? System.Net.WebUtility.HtmlDecode(nodoTitulo.InnerText.Trim()).Replace("\n", " ").Replace("\r", "") : "";
                                string precio = nodoPrecio != null ? System.Net.WebUtility.HtmlDecode(nodoPrecio.InnerText.Trim()).Replace("\n", " ").Replace("\r", "") : "Sin precio";

                                foreach (var term in terminosOmitir) { precio = precio.Replace(term, ""); }
                                precio = precio.Trim();

                                bool esValido = !string.IsNullOrEmpty(nombre);
                                foreach (var palabra in palabrasExcluidas) { if (nombre.Contains(palabra)) { esValido = false; break; } }
                                string claveCache = $"{tienda.Key}_{nombre}";
                                if (esValido && productosAgregados.Add(claveCache)) { AgregarProductoATabla(nombre, precio, tienda.Key); count++; encontrados++; } //pa ebitar duplicados XD
                                if (count == 0) { label_producto_busqueda.Text = $"Sin resultados en {tienda.Key}"; }
                            }
                        }
                        else { label_producto_busqueda.Text = $"Sin resultados en {tienda.Key}"; }
                    }
                    catch { }
                    ;// label_producto_busqueda.Text = $"Error de :{tienda.Key}"; }
                    label_producto_busqueda.Text = $"Resultados para: {textoBuscado} #{encontrados}";
                }
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}