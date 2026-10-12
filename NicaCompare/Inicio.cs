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
        private void tarjetaTienda4_CheckedChanged(object sender, EventArgs e) { ConfigScraper.Tiendas["GCM"]["Activo"] = tarjetaTienda3.Seleccionado ? "SI" : "NO"; }

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

            tablaResultados1.Rows.Clear();
            if (Grid_Compare != null) { Grid_Compare.Rows.Clear(); }
            label_producto_busqueda.Text = $"Buscando: {textoBuscado} por favor espere";
            barraBusqueda1.Text = "";

            await EmpezarBusqueda(textoBuscado);
        }

        private void AgregarProductoATabla(string nombre, string precio, string tiendaKey)
        {
            string nomImg = ConfigScraper.Tiendas[tiendaKey].ContainsKey("img") ? ConfigScraper.Tiendas[tiendaKey]["img"].Replace("Properties.Resources.", "") : "";
            var imgObjeto = !string.IsNullOrEmpty(nomImg) ? Properties.Resources.ResourceManager.GetObject(nomImg) : null;
            Image logo = imgObjeto != null ? (Image)imgObjeto : Properties.Resources.LOGO_22;
            tablaResultados1.Rows.Add(nombre, precio, logo, tiendaKey);
        }

        private void AgregarMejorProductoATabla(string nombre, string precio, string tiendaKey)
        {
            string nomImg = ConfigScraper.Tiendas[tiendaKey].ContainsKey("img") ? ConfigScraper.Tiendas[tiendaKey]["img"].Replace("Properties.Resources.", "") : "";
            var imgObjeto = !string.IsNullOrEmpty(nomImg) ? Properties.Resources.ResourceManager.GetObject(nomImg) : null;
            Image logo = imgObjeto != null ? (Image)imgObjeto : Properties.Resources.LOGO_22;
            string textoCombinado = string.IsNullOrWhiteSpace(precio) ? nombre : $"{precio} - {nombre}";
            if (Grid_Compare != null) { Grid_Compare.Rows.Add(logo, textoCombinado); }
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
                    tareasScraping.Add(ConfigScraper.ScrapearTiendaAsync(client, textoBuscado, tienda));
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

        private void poisonDataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


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