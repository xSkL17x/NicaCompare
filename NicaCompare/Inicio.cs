using ReaLTaiizor.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static NicaCompare.ConfigScraper;

namespace NicaCompare
{

    public partial class Inicio : Form
    {
        //❍﹏﹏﹏﹏﹏﹏  𝐈𝐧𝐢𝐜𝐢𝐚𝐥𝐢𝐜𝐚𝐳𝐢𝐨𝐧 𝐝𝐞 𝐜𝐨𝐝𝐢𝐠𝐨 ──────────────╮
        public Inicio()
        {
            InitializeComponent();
            barraBusqueda1.Text = "Refrigerador Samsung";
            //barraBusqueda1_BuscarClicked_1(this, EventArgs.Empty);
            CargarUsuarioActivo(); IniciarTimerBusquedas();
            CargarEstadoBotones();
        }

        //❍﹏﹏﹏﹏﹏﹏  𝐍𝐚𝐯𝐞𝐠𝐚𝐜𝐢𝐨𝐧 𝐲 𝐀𝐜𝐜𝐢𝐨𝐧𝐞𝐬 𝐝𝐞 𝐔𝐬𝐮𝐚𝐫𝐢𝐨══════╮
        private void botonMenu6_Click_1(object sender, EventArgs e) { Pantallas.cambiar<Form8>(this); }

        private void CargarUsuarioActivo()
        {
            lbl_busquedas_restantes.Text = $"Busquedas\r\nRestantes\r\n({sesion_actual.Busquedas_restantes})\r\n";
            if (GestorUsuario.ValidarSesion())
            {
                boton_usuario.Text = sesion_actual.Nombre;
                boton_usuario.Image = Imgagenes.Obtener(sesion_actual.Img, "usuario");
            }
            else { btn_cerrar_sesion.Hide(); }

        }

        private void boton_usuario_Click(object sender, EventArgs e)
        {
            if (!GestorUsuario.ValidarSesion()) { Pantallas.cambiar<Login>(this); }
            else { Pantallas.cambiar<Form6>(this); }
        }

        private void btn_cerrar_sesion_Click(object sender, EventArgs e)
        {
            sesion_actual.Correo = "";
            sesion_actual.Nombre = "";
            sesion_actual.TipoUsuario = "";
            sesion_actual.Saldo = 0;
            sesion_actual.Telefono = 0;
            sesion_actual.fecha_registro = DateTime.Today;
            Pantallas.cambiar<Login>(this);
        }



        //❍﹏﹏﹏﹏﹏﹏  𝑩𝑶𝑻𝑶𝑵𝑬𝑺 𝑨𝑪𝑻𝑰𝑽𝑨𝑹/𝑫𝑬𝑺𝑨𝑪𝑻𝑰𝑽𝑨𝑹 𝑻𝑰𝑬𝑵𝑫𝑨𝑺  ———————————————๑•̀ᴗ•̀) ̫ ─꒱
        private void tarjetaTienda1_CheckedChanged(object sender, EventArgs e) { ConfigScraper.Tiendas["el GallomasGallo"]["Activo"] = tarjetaTienda1.Seleccionado ? "SI" : "NO"; }
        private void tarjetaTienda2_CheckedChanged(object sender, EventArgs e) { ConfigScraper.Tiendas["SICSA"]["Activo"] = tarjetaTienda2.Seleccionado ? "SI" : "NO"; }
        private void tarjetaTienda3_CheckedChanged(object sender, EventArgs e) { ConfigScraper.Tiendas["GCM"]["Activo"] = tarjetaTienda3.Seleccionado ? "SI" : "NO"; }
        private void tarjetaTienda4_CheckedChanged(object sender, EventArgs e) { ConfigScraper.Tiendas["La Curacao Nicaragua"]["Activo"] = tarjetaTienda4.Seleccionado ? "SI" : "NO"; }

        private void CargarEstadoBotones()
        {
            tarjetaTienda1.Seleccionado = ConfigScraper.Tiendas["el GallomasGallo"]["Activo"] == "SI";
            tarjetaTienda2.Seleccionado = ConfigScraper.Tiendas["SICSA"]["Activo"] == "SI";
            tarjetaTienda3.Seleccionado = ConfigScraper.Tiendas["GCM"]["Activo"] == "SI";
            tarjetaTienda4.Seleccionado = ConfigScraper.Tiendas["La Curacao Nicaragua"]["Activo"] == "SI";
        }

        //✧----------------------- 𝐁𝐀𝐑𝐑𝐀 𝐃𝐄 𝐁𝐔𝐒𝐐𝐔𝐄𝐃𝐀 -----------------------➣


        private bool buscando = false; // para esperar a que termine una busqueda
        private async void barraBusqueda1_BuscarClicked_1(object sender, EventArgs e)
        {
            string textoBuscado = barraBusqueda1.Text;
            if (string.IsNullOrWhiteSpace(textoBuscado)) { return; }

            if (sesion_actual.Busquedas_restantes <= 0)
            {
                MessageBox.Show("Te has quedado sin búsquedas. Por favor espere para otro intento.", "Límite alcanzado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (buscando)
            {
                MessageBox.Show("Espere a terminar la búsqueda actual.", "Búsqueda en curso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (textoBuscado.Length < 3)
            {
                DialogResult resultado = MessageBox.Show($"¿Estás seguro que deseas buscar \"{textoBuscado}\"?", "Confirmar búsqueda", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.No) { barraBusqueda1.Text = ""; return; }
            }

            GestorUsuario.Actualizar(sesion_actual.Correo, Busquedas: sesion_actual.Busquedas_restantes - 1);
            lbl_busquedas_restantes.Text = $"Busquedas\r\nRestantes\r\n({sesion_actual.Busquedas_restantes})\r\n";
            tablaResultados1.Rows.Clear();
            if (Grid_Compare != null) { Grid_Compare.Rows.Clear(); }
            label_producto_busqueda.Text = $"Buscando: {textoBuscado} por favor espere";
            barraBusqueda1.Text = "";

            await EmpezarBusqueda(textoBuscado);
        }


        // Sistema de filtro

        private void CrearFiltros(List<string> nombresProductos)
        {
            // Limpiamos el panel por si había filtros de una búsqueda anterior
            panel_filtros.Controls.Clear();

            // 1. FILTRADO DINÁMICO DE MARCAS: Verificamos cuáles marcas de nuestro diccionario salieron en los resultados
            HashSet<string> marcasEncontradas = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            foreach (var prod in nombresProductos)
            {
                foreach (var marcaItem in FiltrosProductos.Marcas)
                {
                    foreach (var keyword in marcaItem.Value)
                    {
                        if (prod.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0)
                        {
                            marcasEncontradas.Add(marcaItem.Key);
                        }
                    }
                }
            }

            // Si encontramos marcas en los resultados, creamos el ComboBox de Marcas estilo Amazon
            if (marcasEncontradas.Count > 0)
            {
                ComboBoxEdit combo_box_marcas = new ComboBoxEdit();
                combo_box_marcas.Name = "combo_box_marcas";
                combo_box_marcas.Width = 160;
                combo_box_marcas.Location = new System.Drawing.Point(15, 12);
                combo_box_marcas.DropDownStyle = ComboBoxStyle.DropDownList;

                combo_box_marcas.Items.Add("Todas las marcas");
                foreach (var marca in marcasEncontradas)
                {
                    combo_box_marcas.Items.Add(marca);
                }
                combo_box_marcas.SelectedIndex = 0;

                panel_filtros.Controls.Add(combo_box_marcas);
            }

            // 2. FILTRADO DINÁMICO DE ATRIBUTOS (Ej: Pantallas o Refrigeración según aplique)
            HashSet<string> atributosEncontrados = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            foreach (var prod in nombresProductos)
            {
                foreach (var categoria in FiltrosProductos.Atributos)
                {
                    foreach (var attr in categoria.Value)
                    {
                        if (prod.IndexOf(attr, StringComparison.OrdinalIgnoreCase) >= 0)
                        {
                            atributosEncontrados.Add(attr);
                        }
                    }
                }
            }

            // Si el usuario buscó pantallas o refris y hay atributos, creamos el segundo ComboBox al lado
            if (atributosEncontrados.Count > 0)
            {
                ComboBoxEdit combo_box_atributos = new ComboBoxEdit();
                combo_box_atributos.Name = "combo_box_atributos";
                combo_box_atributos.Width = 160;
                combo_box_atributos.Location = new System.Drawing.Point(190, 12); // Desplazado a la par del otro
                combo_box_atributos.DropDownStyle = ComboBoxStyle.DropDownList;

                combo_box_atributos.Items.Add("Todas las especificaciones");
                foreach (var attr in atributosEncontrados)
                {
                    combo_box_atributos.Items.Add(attr);
                }
                combo_box_atributos.SelectedIndex = 0;

                panel_filtros.Controls.Add(combo_box_atributos);
            }
        }



        //  ----------------------- Sistema de Intentos de busquedas -----------------------➣


        private System.Windows.Forms.Timer? timerBusquedas;
        private int segundosRestantes = 300;
        private void IniciarTimerBusquedas()
        {

            timerBusquedas = new System.Windows.Forms.Timer();
            timerBusquedas.Interval = 1000;

            label_ag_busqueda.Text = $"Agregando \r\nuna busqueda\r\nen {segundosRestantes} segundos";

            timerBusquedas.Tick += (sender, e) =>
            {
                segundosRestantes -= 1;

                if (segundosRestantes <= 0)
                {
                    GestorUsuario.Actualizar(sesion_actual.Correo, Busquedas: sesion_actual.Busquedas_restantes + 1);
                    lbl_busquedas_restantes.Text = $"Busquedas\r\nRestantes\r\n({sesion_actual.Busquedas_restantes})\r\n";
                    segundosRestantes = 300;
                }

                label_ag_busqueda.Text = $"Agregando \r\nuna busqueda\r\nen {segundosRestantes} segundos";
            };

            timerBusquedas.Start();
        }
        // —————————————————》✧𝐓𝐚𝐛𝐥𝐚𝐬 (𝐅𝐮𝐧𝐜𝐢𝐨𝐧 𝐩𝐚𝐫𝐚 𝐚𝐠𝐫𝐞𝐠𝐚𝐫 𝐏𝐫𝐨𝐝𝐮𝐜𝐭𝐨𝐬)✧《———————————————————————

        private void AgregarProductoATabla(string nombre, string precio, string tiendaKey)
        {
            string nomImg = ConfigScraper.Tiendas.ContainsKey(tiendaKey) && ConfigScraper.Tiendas[tiendaKey].ContainsKey("img") ? ConfigScraper.Tiendas[tiendaKey]["img"] : "";//obtener img de tienda
            Image logo = Imgagenes.Obtener(nomImg);
            tablaResultados1.Rows.Add(nombre, precio, logo, tiendaKey);
        }

        private void AgregarMejorProductoATabla(string nombre, string precio, string tiendaKey)
        {
            string nomImg = ConfigScraper.Tiendas.ContainsKey(tiendaKey) && ConfigScraper.Tiendas[tiendaKey].ContainsKey("img") ? ConfigScraper.Tiendas[tiendaKey]["img"] : "";//obtener img de tienda
            Image logo = Imgagenes.Obtener(nomImg);

            string textoCombinado = string.IsNullOrWhiteSpace(precio) ? nombre : $"{precio} | \n{nombre}";
            if (Grid_Compare != null) { Grid_Compare.Rows.Add(logo, textoCombinado); }
        }

        private async Task EmpezarBusqueda(string textoBuscado)
        {
            buscando = true;
            try
            {

                List<Task<(string, List<ProductoResult>)>> tareasScraping = new List<Task<(string, List<ProductoResult>)>>(); // Tarea de scraping (DOnde se guardaran los productos)
                var handler = new HttpClientHandler
                {
                    AllowAutoRedirect = true,
                    AutomaticDecompression = System.Net.DecompressionMethods.GZip | System.Net.DecompressionMethods.Deflate | System.Net.DecompressionMethods.Brotli
                };

                using (HttpClient client = new HttpClient(handler))
                {

                    foreach (var tienda in ConfigScraper.Tiendas) // ver que tiendan se buscaran (usando diccionario o db)
                    {
                        if (tienda.Value.ContainsKey("Activo") && tienda.Value["Activo"] == "NO") continue; // si esta en "NO", Pasar a la siguiente tienda.
                        tareasScraping.Add(ConfigScraper.ScrapearTiendaAsync(client, textoBuscado, tienda)); // si esta activa, agregar la tarea de scraping a la lista de tareas.
                    }

                    // Esperamos a que todas las tiendas agan la busqueda.
                    var resultadosPorTienda = await Task.WhenAll(tareasScraping);
                    int totalEncontrados = 0;

                    List<ProductoResult> losMasBaratos = new List<ProductoResult>(); // lista de los productos para ordenar por precio
                    HashSet<string> productosAgregadosGlobal = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

                    // revisar y filtrar repetidos y los meter a la tabla de todos
                    foreach (var res in resultadosPorTienda)
                    {
                        if (res.Item2.Count > 0)
                        {
                            foreach (var prod in res.Item2)
                            {
                                string claveCache = $"{prod.TiendaKey}_{prod.Nombre}";
                                if (productosAgregadosGlobal.Add(claveCache)) { AgregarProductoATabla(prod.Nombre, prod.PrecioTexto, prod.TiendaKey); totalEncontrados++; } // < aqui lo manda a la tabla
                            }

                            // Busca el Producto más barato de cada tienda y lo agrega a la lista de losMasBaratos
                            var masBarato = res.Item2.Where(p => p.PrecioMonto < decimal.MaxValue).OrderBy(p => p.PrecioMonto).FirstOrDefault();
                            if (masBarato != null) { losMasBaratos.Add(masBarato); }
                        }
                        else { losMasBaratos.Add(new ProductoResult { Nombre = "No disponible en esta tienda", PrecioTexto = "", PrecioMonto = decimal.MaxValue, TiendaKey = res.Item1 }); }
                    }

                    // Ordenamos de menor precio a mayor . . .
                losMasBaratos = losMasBaratos.OrderBy(p => p.PrecioMonto).ToList();
                foreach (var mejor in losMasBaratos) { AgregarMejorProductoATabla(mejor.Nombre, mejor.PrecioTexto, mejor.TiendaKey); }

                label_producto_busqueda.Text = $"Resultados para: {textoBuscado} #{totalEncontrados}";

                // (Dentro de EmpezarBusqueda, justo antes del finally / al tener todos los productos procesados)
                List<string> nombresDeProductosObtenidos = new List<string>();

                foreach (var res in resultadosPorTienda)
                {
                    foreach (var prod in res.Item2)
                    {
                        nombresDeProductosObtenidos.Add(prod.Nombre);
                    }
                }

                // Genera los filtros dinámicamente en base a lo que arrojó la búsqueda estilo Amazon
                CrearFiltros(nombresDeProductosObtenidos);
                }
            }
            finally { buscando = false; }
        }





        //❍﹏﹏﹏﹏﹏﹏  𝗠𝗲𝘁𝗼𝗱𝗼𝘀 𝗩𝗮𝗰𝗶𝗼𝘀 / 𝗘𝘃𝗲𝗻𝘁𝗼𝘀 𝗻𝗼 𝘂𝘀𝗮𝗱𝗼𝘀  ﹏﹏﹏﹏﹏﹏﹏﹏﹏﹏﹏❍
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
        private void poisonDataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void botonCategoriaCheck5_Click(object sender, EventArgs e)
        {

        }

        private void Hogar_Click(object sender, EventArgs e)
        {

        }

        private void botonCategoriaCheck3_Click_1(object sender, EventArgs e)
        {

        }
    }



    //❍﹏﹏﹏﹏﹏﹏  plantilla para ordenar productos encontrados ﹏﹏﹏﹏﹏﹏﹏﹏﹏﹏﹏❍
    public class ProductoResult
    {
        public string Nombre { get; set; } = "";
        public string PrecioTexto { get; set; } = "";
        public decimal PrecioMonto { get; set; }
        public string TiendaKey { get; set; } = "";
    }
}