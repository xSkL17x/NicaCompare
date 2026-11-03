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
            barraBusqueda1.Text = "Refri";
            CargarUsuarioActivo();
            IniciarTimerBusquedas();
            CargarEstadoBotones();
        }

        //❍﹏﹏﹏﹏﹏﹏  𝐍𝐚𝐯𝐞𝐠𝐚𝐜𝐢𝐨𝐧 𝐲 𝐀𝐜𝐜𝐢𝐨𝐧𝐞𝐬 𝐝𝐞 𝐔𝐬𝐮𝐚𝐫𝐢𝐨══════╮
        private void botonMenu6_Click_1(object sender, EventArgs e) { Pantallas.cambiar<Form8>(this); }

        private void CargarUsuarioActivo()
        {
            lbl_busquedas_restantes.Text = $"{sesion_actual.Busquedas_restantes}";
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

        //❍﹏﹏﹏﹏﹏﹏  𝑩𝑶𝑻𝑶𝑵𝑬𝑺 𝑨𝑪𝑻𝑰𝑽𝑨𝑹/𝑫𝑬𝑺𝑨𝑪𝑻𝑰𝑽𝑨𝑹 𝑻𝑰𝑬𝑵𝑫𝑨𝚂  ———————————————๑•̀ᴗ•̀) ̫ ─꒱

        private void tarjetaTienda1_CheckedChanged(object sender, EventArgs e) { ConfigScraper.Tiendas["el GallomasGallo"]["Activo"] = tarjetaTienda1.Seleccionado ? "SI" : "NO"; }
        private void tarjetaTienda2_CheckedChanged(object sender, EventArgs e) { ConfigScraper.Tiendas["SICSA"]["Activo"] = tarjetaTienda2.Seleccionado ? "SI" : "NO"; }
        private void tarjetaTienda3_CheckedChanged(object sender, EventArgs e) { ConfigScraper.Tiendas["GCM"]["Activo"] = tarjetaTienda3.Seleccionado ? "SI" : "NO"; }
        private void tarjetaTienda4_CheckedChanged(object sender, EventArgs e) { ConfigScraper.Tiendas["WALMART"]["Activo"] = tarjetaTienda4.Seleccionado ? "SI" : "NO"; }
        private void tarjetaTienda5_CheckedChanged(object sender, EventArgs e) { ConfigScraper.Tiendas["La Curacao"]["Activo"] = tarjetaTienda5.Seleccionado ? "SI" : "NO"; }
        private void tarjetaTienda6_CheckedChanged(object sender, EventArgs e) { ConfigScraper.Tiendas["RadioShack"]["Activo"] = tarjetaTienda6.Seleccionado ? "SI" : "NO"; }


        private void CargarEstadoBotones()
        {
            tarjetaTienda1.Seleccionado = ConfigScraper.Tiendas["el GallomasGallo"]["Activo"] == "SI";
            tarjetaTienda2.Seleccionado = ConfigScraper.Tiendas["SICSA"]["Activo"] == "SI";
            tarjetaTienda3.Seleccionado = ConfigScraper.Tiendas["GCM"]["Activo"] == "SI";
            tarjetaTienda4.Seleccionado = ConfigScraper.Tiendas["WALMART"]["Activo"] == "SI";
            tarjetaTienda5.Seleccionado = ConfigScraper.Tiendas["La Curacao"]["Activo"] == "SI";
            tarjetaTienda6.Seleccionado = ConfigScraper.Tiendas["RadioShack"]["Activo"] == "SI";
        }

        //✧----------------------- 𝐁𝐀𝐑𝐑𝐀 𝐃𝐄 𝐁𝐔𝐒𝐐𝐔𝐄𝐃🇦 -----------------------➣
        private bool buscando = false;

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
            int tiendasSeleccionadas = 0;
            if (tarjetaTienda1.Seleccionado) tiendasSeleccionadas++;
            if (tarjetaTienda2.Seleccionado) tiendasSeleccionadas++;
            if (tarjetaTienda3.Seleccionado) tiendasSeleccionadas++;
            if (tarjetaTienda4.Seleccionado) tiendasSeleccionadas++;
            if (tarjetaTienda5.Seleccionado) tiendasSeleccionadas++;
            if (tarjetaTienda6.Seleccionado) tiendasSeleccionadas++;
            if (tiendasSeleccionadas == 0)
            {
                MessageBox.Show("Por favor seleccione al menos 1 tienda para hacer la búsqueda.", "Tiendas requeridas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string planUsuario = sesion_actual.TipoUsuario ?? "Gratis";
            int limiteTiendas = 3;
            string planLower = planUsuario.ToLower();
            if (planLower.Contains("básico") || planLower.Contains("basico")) limiteTiendas = 4;
            else if (planLower.Contains("premium")) limiteTiendas = 5;
            else if (planLower.Contains("elite") || planLower.Contains("élite")) limiteTiendas = 6;
            if (tiendasSeleccionadas > limiteTiendas)
            {
                MessageBox.Show($"Tu plan actual solo deja buscar {limiteTiendas} tiendas.", "Límite de tiendas excedido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (textoBuscado.Length < 3)
            {
                DialogResult resultado = MessageBox.Show($"¿Estás seguro que deseas buscar \"{textoBuscado}\"?", "Confirmar búsqueda", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.No) { barraBusqueda1.Text = ""; return; }
            }
            GestorUsuario.Actualizar(sesion_actual.Correo, Busquedas: sesion_actual.Busquedas_restantes - 1);
            lbl_busquedas_restantes.Text = $"{sesion_actual.Busquedas_restantes}";
            tablaResultados1.Rows.Clear();
            if (Grid_Compare != null) { Grid_Compare.Rows.Clear(); }
            label_producto_busqueda.Text = $"Buscando: {textoBuscado} por favor espere";
            barraBusqueda1.Text = "";
            await EmpezarBusqueda(textoBuscado);
        }

        //❍﹏﹏﹏﹏﹏﹏  𝐆𝐄𝐒𝐓𝐈𝐎𝐍 𝐃𝐄 𝐅𝐈𝐋𝐓𝐑𝐎𝐒 𝐘 𝐑𝐀𝐍𝐆𝐎𝐒  ──────────────╮
        private void CrearFiltros(List<string> nombresProductos)
        {
            // 1. Marcas
            HashSet<string> marcasEncontradas = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            foreach (var prod in nombresProductos)
                foreach (var marcaItem in FiltrosProductos.Marcas)
                    foreach (var keyword in marcaItem.Value)
                        if (prod.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0)
                            marcasEncontradas.Add(marcaItem.Key);

            comboMarca.Items.Clear();
            comboMarca.Items.Add("Todas las marcas");
            foreach (var marca in marcasEncontradas) comboMarca.Items.Add(marca);
            comboMarca.SelectedIndex = 0;
            comboMarca.Visible = true;

            // 2. Atributos
            HashSet<string> atributosEncontrados = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            foreach (var prod in nombresProductos)
                foreach (var categoria in FiltrosProductos.Atributos)
                    foreach (var attr in categoria.Value)
                        if (prod.IndexOf(attr, StringComparison.OrdinalIgnoreCase) >= 0)
                            atributosEncontrados.Add(attr);

            comboAtributo.Items.Clear();
            comboAtributo.Items.Add("Mas especificaciones");
            foreach (var attr in atributosEncontrados) comboAtributo.Items.Add(attr);
            comboAtributo.SelectedIndex = 0;
            comboAtributo.Visible = true;

            // 3. Precios y Rangos (Trackbars y Labels)
            decimal precioMinimoReal = 0;
            decimal precioMaximoReal = 50000;

            if (listaProductos != null && listaProductos.Any(p => p.PrecioMonto < decimal.MaxValue))
            {
                var validos = listaProductos.Where(p => p.PrecioMonto < decimal.MaxValue);
                precioMinimoReal = validos.Min(p => p.PrecioMonto);
                precioMaximoReal = validos.Max(p => p.PrecioMonto);
            }

            label_precio.Visible = true;
            TrackBarMinimo.Visible = true;
            TrackBarMaximo.Visible = true;

            LabelRangoMinimo.Text = $"C$ {(int)precioMinimoReal:N0}";
            LabelRangoMinimo.Visible = true;

            LabelRangoMaximo.Text = $"C$ {(int)precioMaximoReal:N0}";
            LabelRangoMaximo.Visible = true;
        }

        // ----------------------- Timer de intentos -----------------------➣
        private System.Windows.Forms.Timer? timerBusquedas;
        private int segundosRestantes = 300;
        private void IniciarTimerBusquedas()
        {
            timerBusquedas = new System.Windows.Forms.Timer();
            timerBusquedas.Interval = 1000;
            label_ag_busqueda.Text = $"{TimeSpan.FromSeconds(segundosRestantes):mm\\:ss}";

            timerBusquedas.Tick += (sender, e) =>
            {
                segundosRestantes -= 1;
                if (segundosRestantes <= 0)
                {
                    GestorUsuario.Actualizar(sesion_actual.Correo, Busquedas: sesion_actual.Busquedas_restantes + 1);
                    lbl_busquedas_restantes.Text = $"{sesion_actual.Busquedas_restantes}";
                    segundosRestantes = 300; // Puedes modificar este valor directamente aquí o cambiar la variable global cuando quieras
                }
                label_ag_busqueda.Text = $"{TimeSpan.FromSeconds(segundosRestantes):mm\\:ss}";
            };

            timerBusquedas.Start();
        }

        // —————————————————》✧𝐓𝐚𝐛𝐥as✧《———————————————————————
        private int AgregarMejorProductoATabla(string nombre, string precio, string tiendaKey)
        {
            string nomImg = ConfigScraper.Tiendas.ContainsKey(tiendaKey) && ConfigScraper.Tiendas[tiendaKey].ContainsKey("img") ? ConfigScraper.Tiendas[tiendaKey]["img"] : "";
            Image logo = Imgagenes.Obtener(nomImg);
            string textoCombinado = string.IsNullOrWhiteSpace(precio) ? nombre : $"{precio} | \n{nombre}";

            return Grid_Compare.Rows.Add(logo, textoCombinado);
        }

        private int AgregarProductoATabla(string nombre, string precio, string tiendaKey)
        {
            string nomImg = ConfigScraper.Tiendas.ContainsKey(tiendaKey) && ConfigScraper.Tiendas[tiendaKey].ContainsKey("img") ? ConfigScraper.Tiendas[tiendaKey]["img"] : "";
            Image logo = Imgagenes.Obtener(nomImg);

            return tablaResultados1.Rows.Add(nombre, precio, logo, tiendaKey);
        }

        // Lista  para guardar productos y filtrar localmente sin volver a scrapear
        private List<ProductoResult> listaProductos = new List<ProductoResult>();

        //❍﹏﹏﹏﹏﹏﹏  𝐌𝐎𝐓𝐎𝐑 𝐃𝐄 𝐒𝐂𝐑𝐀𝐏𝐈𝐍𝐆 𝐘 𝐅𝐈𝐋𝐓𝐑𝐀𝐃𝐎  ══════╮
        private async Task EmpezarBusqueda(string textoBuscado)
        {
            buscando = true;
            try
            {
                tablaResultados1.Rows.Clear();
                if (Grid_Compare != null) { Grid_Compare.Rows.Clear(); }
                listaProductos.Clear();
                label_producto_busqueda.Text = $"Buscando: {textoBuscado}";

                List<Task> tareasTiendas = new List<Task>();

                // Recorremos las tiendas activas para lanzar el scraping en paralelo
                foreach (var tienda in ConfigScraper.Tiendas)
                {
                    if (tienda.Value.ContainsKey("Activo") && tienda.Value["Activo"] == "NO") { continue; }

                    var tiendaActual = tienda;
                    var tareaTienda = Task.Run(async () =>
                    {
                        var resultadoScraping = await ConfigScraper.ScrapearTiendaAsync(textoBuscado, tiendaActual);

                        // Actualizamos la interfaz conforme cada tienda va respondiendo
                        this.Invoke((MethodInvoker)delegate
                        {
                            if (resultadoScraping.Item2 != null && resultadoScraping.Item2.Count > 0)
                            {
                                listaProductos.AddRange(resultadoScraping.Item2);
                                ActualizarTablaConFiltros();

                                List<string> nombresProductos = listaProductos.Select(p => p.Nombre).ToList();
                                CrearFiltros(nombresProductos);
                            }

                            // Actualizamos el estado temporal en el label con la tienda actual
                            label_producto_busqueda.Text = $"Resultados para: {textoBuscado} #{listaProductos.Count} | Buscando en {tiendaActual.Key}";
                        });
                    });

                    tareasTiendas.Add(tareaTienda);
                }

                await Task.WhenAll(tareasTiendas);
                label_producto_busqueda.Text = $"Resultados para: {textoBuscado} #{listaProductos.Count} ✔";
            }
            finally { buscando = false; }
        }

        private void ActualizarTablaConFiltros()
        {
            tablaResultados1.Rows.Clear();
            if (Grid_Compare != null) { Grid_Compare.Rows.Clear(); }

            string marcaSeleccionada = comboMarca.SelectedItem?.ToString() ?? "Todas las marcas";
            string atributoSeleccionado = comboAtributo.SelectedItem?.ToString() ?? "Mas especificaciones";

            int precioMaxSeleccionado = int.MaxValue;

            var productosFiltrados = listaProductos.Where(prod =>
            {
                // Filtro para descartar productos agotados (precio 0 o menor)
                if (prod.PrecioMonto <= 0) return false;

                bool pasaMarca = true;
                if (marcaSeleccionada != "Todas las marcas" && !string.IsNullOrEmpty(marcaSeleccionada))
                {
                    if (FiltrosProductos.Marcas.ContainsKey(marcaSeleccionada))
                    {
                        var keywords = FiltrosProductos.Marcas[marcaSeleccionada];
                        pasaMarca = keywords.Any(kw => prod.Nombre.IndexOf(kw, StringComparison.OrdinalIgnoreCase) >= 0);
                    }
                }

                bool pasaAtributo = true;
                if (atributoSeleccionado != "Mas especificaciones" && !string.IsNullOrEmpty(atributoSeleccionado))
                {
                    pasaAtributo = prod.Nombre.IndexOf(atributoSeleccionado, StringComparison.OrdinalIgnoreCase) >= 0;
                }

                bool pasaPrecio = prod.PrecioMonto <= precioMaxSeleccionado;

                return pasaMarca && pasaAtributo && pasaPrecio;
            }).OrderBy(p => p.PrecioMonto).ToList();

            HashSet<string> productosAgregadosGlobal = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            foreach (var prod in productosFiltrados)
            {
                string claveCache = $"{prod.TiendaKey}_{prod.Nombre}";
                if (productosAgregadosGlobal.Add(claveCache))
                {
                    string precioLimpiado = ObtenerPrimerPrecio(prod.PrecioTexto);
                    int rowIndex = AgregarProductoATabla(prod.Nombre, precioLimpiado, prod.TiendaKey);
                    if (rowIndex >= 0 && rowIndex < tablaResultados1.Rows.Count) { tablaResultados1.Rows[rowIndex].Tag = prod; }
                }
            }

            foreach (DataGridViewColumn col in tablaResultados1.Columns) { col.SortMode = DataGridViewColumnSortMode.NotSortable; }

            List<ProductoResult> losMasBaratos = new List<ProductoResult>();

            foreach (var tienda in ConfigScraper.Tiendas)
            {
                string tiendaKey = tienda.Key;
                if (tienda.Value.ContainsKey("Activo") && tienda.Value["Activo"] == "NO") continue;

                var prodsDeEstaTienda = productosFiltrados.Where(p => p.TiendaKey.Equals(tiendaKey, StringComparison.OrdinalIgnoreCase)).ToList();

                if (prodsDeEstaTienda.Count > 0)
                {
                    var masBarato = prodsDeEstaTienda.Where(p => p.PrecioMonto < decimal.MaxValue).OrderBy(p => p.PrecioMonto).FirstOrDefault();
                    if (masBarato != null) { losMasBaratos.Add(masBarato); }
                }
                else
                {
                    losMasBaratos.Add(new ProductoResult { Nombre = "No disponible en esta tienda", PrecioTexto = "", PrecioMonto = decimal.MaxValue, TiendaKey = tiendaKey, Url = "", Imagen = "" });
                }
            }

            losMasBaratos = losMasBaratos.OrderBy(p => p.PrecioMonto).ToList();
            foreach (var mejor in losMasBaratos)
            {
                string precioMejorLimpiado = ObtenerPrimerPrecio(mejor.PrecioTexto);
                int rowIndexCompare = AgregarMejorProductoATabla(mejor.Nombre, precioMejorLimpiado, mejor.TiendaKey);
                if (Grid_Compare != null && rowIndexCompare >= 0 && rowIndexCompare < Grid_Compare.Rows.Count)
                {
                    Grid_Compare.Rows[rowIndexCompare].Tag = mejor;
                }
            }
            if (Grid_Compare != null) { foreach (DataGridViewColumn col in Grid_Compare.Columns) { col.SortMode = DataGridViewColumnSortMode.NotSortable; } }
        }

        //❍﹏﹏﹏﹏﹏﹏  𝗠𝗲𝘁𝗼𝗱𝗼𝘀 𝗩𝗮𝗰𝗶𝗼𝘀  ﹏﹏﹏﹏﹏﹏﹏﹏﹏﹏﹏❍
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

        //✧----------------------- 𝐄𝐕𝐄𝐍𝐓𝐎𝐒 𝐃𝐄 𝐓𝐀𝐁𝐋𝐀𝐒 𝐘 𝐄𝐍𝐋𝐀𝐂𝐄𝐒 -----------------------➣
        private void poisonDataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e) { ProcesarClickEnTabla(sender, e, "Abrir Enlace"); }

        private void Grid_Compare_CellContentClick(object sender, DataGridViewCellEventArgs e) { ProcesarClickEnTabla(sender, e, "Abrir Enlace (Comparación)"); }

        //funcon para ir al url
        private void ProcesarClickEnTabla(object sender, DataGridViewCellEventArgs e, string tituloVentana)
        {
            if (e.RowIndex >= 0)
            {
                var grid = sender as DataGridView;
                if (grid != null)
                {
                    var producto = grid.Rows[e.RowIndex].Tag as ProductoResult;
                    if (producto != null && !string.IsNullOrEmpty(producto.Url))
                    {
                        // AQUÍ RECORTAMOS EL TEXTO: Nos quedamos solo con las primeras 5 palabras (o ajusta el número a tu gusto)
                        string nombreCorto = Utilidad.AcortarTexto(producto.Nombre, 5);

                        DialogResult resultado = MessageBox.Show(
                            $"Producto: {nombreCorto}\n\n¿Deseas abrir la página de este producto?",
                            tituloVentana,
                            MessageBoxButtons.OKCancel,
                            MessageBoxIcon.Question
                        );

                        if (resultado == DialogResult.OK)
                        {
                            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                            {
                                FileName = producto.Url,
                                UseShellExecute = true
                            });
                        }
                    }
                }
            }
        }

        //❍﹏﹏﹏﹏﹏﹏  𝐂𝐀𝐓𝐄𝐆𝐎𝐑𝐈𝐀𝐒 𝐘 𝐂𝐎𝐍𝐓𝐑𝐎𝐋𝐄𝐒  ──────────────╮
        private void Tecnología_Click(object sender, EventArgs e) { SeleccionarCategoria(Tecnología, "Tecnología"); }
        private void Hogar_Click(object sender, EventArgs e) { SeleccionarCategoria(Hogar, "Hogar"); }
        private void botonCategoriaCelulares_Click(object sender, EventArgs e) { SeleccionarCategoria(Celulares, "Celulares"); }
        private void botonCategoriaElectrodomesticos_Click(object sender, EventArgs e) { SeleccionarCategoria(Categoria_electrodomesticos, "Electrodomésticos"); }

        private async void SeleccionarCategoria(BotonCategoriaCheck botonActual, string nombreCategoria)
        {
            BotonCategoriaCheck[] grupoBotones = new[] { Tecnología, Hogar, Celulares, Categoria_electrodomesticos };
            if (sesion_actual.Busquedas_restantes <= 0)
            {
                foreach (var btn in grupoBotones) { btn.Checked = false; }
                MessageBox.Show("Te has quedado sin búsquedas. Por favor espere para otro intento.", "Límite alcanzado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (var btn in grupoBotones) { if (btn != null && btn != botonActual) { btn.Checked = false; } }
            if (!botonActual.Checked) { botonActual.Checked = true; }

            // restar puntos etcc (funcion similar a lo de busqueda)
            GestorUsuario.Actualizar(sesion_actual.Correo, Busquedas: sesion_actual.Busquedas_restantes - 1);
            lbl_busquedas_restantes.Text = $"{sesion_actual.Busquedas_restantes}";
            tablaResultados1.Rows.Clear(); Grid_Compare.Rows.Clear();

            barraBusqueda1.Text = "";

            await EmpezarBusqueda(nombreCategoria);
            barraBusqueda1.Text = "";
        }

        private void comboMarca_SelectedIndexChanged(object sender, EventArgs e) { ActualizarTablaConFiltros(); }
        private void comboAtributo_SelectedIndexChanged(object sender, EventArgs e) { ActualizarTablaConFiltros(); }
        private void TrackBarMinimo_Scroll(object sender, ScrollEventArgs e) { ActualizarTablaConFiltros(); }
        private void TrackBarMaximo_Scroll(object sender, ScrollEventArgs e) { ActualizarTablaConFiltros(); }


    }

    //❍﹏﹏﹏﹏﹏﹏  𝐌𝐎𝐃𝐄𝐋𝐎 𝐃𝐄 𝐃𝐀𝐓𝐎𝐒  ──────────────╮
    public class ProductoResult
    {
        public string Nombre { get; set; } = "";
        public string PrecioTexto { get; set; } = "";
        public decimal PrecioMonto { get; set; }
        public string TiendaKey { get; set; } = "";

        public string Imagen { get; set; } = "";
        public string Url { get; set; } = "";
    }
}