using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;

namespace NicaCompare
{
    public enum EstadoOfertaTienda
    {
        MejorOferta,
        EnStock,
        NoDisponible
    }

    public class ItemTiendaComparacion
    {
        public string NombreTienda { get; set; } = "Tienda";
        public decimal Precio { get; set; } = 0.00m;
        public string SimboloMoneda { get; set; } = "C$";
        public bool Disponible { get; set; } = true;
        public EstadoOfertaTienda Estado { get; internal set; } = EstadoOfertaTienda.EnStock;

        public ItemTiendaComparacion() { }

        public ItemTiendaComparacion(string nombre, decimal precio, bool disponible = true, string simbolo = "C$")
        {
            NombreTienda = nombre;
            Precio = precio;
            Disponible = disponible;
            SimboloMoneda = simbolo;
        }
    }

    [DefaultEvent("Click")]
    public class TarjetaResultadoComparacion : UserControl
    {
        private string tituloSeccion = "Resultados";
        private string nombreProducto = "Nombre del producto";
        private string subtituloProducto = "Categoría / Descripción";
        private List<ItemTiendaComparacion> tiendas = new List<ItemTiendaComparacion>();

        // Recursos estáticos de fuentes y colores (rendimiento máximo)
        private static readonly Font FontTitulo = new Font("Segoe UI", 12F, FontStyle.Bold);
        private static readonly Font FontNombreProd = new Font("Segoe UI", 11F, FontStyle.Bold);
        private static readonly Font FontSubProd = new Font("Segoe UI", 8.5F, FontStyle.Regular);
        private static readonly Font FontBadgeTienda = new Font("Segoe UI", 8.5F, FontStyle.Bold);
        private static readonly Font FontPrecio = new Font("Segoe UI", 10.5F, FontStyle.Bold);
        private static readonly Font FontBadgeEstado = new Font("Segoe UI", 8F, FontStyle.Bold);

        private static readonly Color ColorBordeGris = Color.FromArgb(226, 232, 240);
        private static readonly Color ColorTextoOscuro = Color.FromArgb(15, 23, 42);
        private static readonly Color ColorTextoGris = Color.FromArgb(100, 116, 139);

        [Category("NicaCompare Custom")]
        public string TituloSeccion
        {
            get => tituloSeccion;
            set { tituloSeccion = value ?? string.Empty; Invalidate(); }
        }

        [Category("NicaCompare Custom")]
        public string NombreProducto
        {
            get => nombreProducto;
            set { nombreProducto = value ?? string.Empty; Invalidate(); }
        }

        [Category("NicaCompare Custom")]
        public string SubtituloProducto
        {
            get => subtituloProducto;
            set { subtituloProducto = value ?? string.Empty; Invalidate(); }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<ItemTiendaComparacion> Tiendas
        {
            get => tiendas;
            set
            {
                tiendas = value ?? new List<ItemTiendaComparacion>();
                RecalcularMejorOferta();
                Invalidate();
            }
        }

        public TarjetaResultadoComparacion()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.UserPaint |
                     ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.ResizeRedraw, true);

            Size = new Size(780, 200);
            BackColor = Color.Transparent;
            DoubleBuffered = true;
        }

        // --- MÉTODOS PARA AGREGAR TIENDAS DINÁMICAMENTE ---

        public void AgregarTienda(string nombre, decimal precio, bool disponible = true, string simbolo = "C$")
        {
            tiendas.Add(new ItemTiendaComparacion(nombre, precio, disponible, simbolo));
            RecalcularMejorOferta();
            Invalidate();
        }

        public void LimpiarTiendas()
        {
            tiendas.Clear();
            Invalidate();
        }

        public void RecalcularMejorOferta()
        {
            if (tiendas == null || tiendas.Count == 0) return;

            var disponibles = tiendas.Where(t => t.Disponible && t.Precio > 0).ToList();

            if (disponibles.Count > 0)
            {
                decimal menorPrecio = disponibles.Min(t => t.Precio);

                foreach (var tienda in tiendas)
                {
                    if (!tienda.Disponible)
                    {
                        tienda.Estado = EstadoOfertaTienda.NoDisponible;
                    }
                    else if (tienda.Precio == menorPrecio)
                    {
                        tienda.Estado = EstadoOfertaTienda.MejorOferta;
                    }
                    else
                    {
                        tienda.Estado = EstadoOfertaTienda.EnStock;
                    }
                }
            }
            else
            {
                foreach (var tienda in tiendas)
                {
                    tienda.Estado = tienda.Disponible ? EstadoOfertaTienda.EnStock : EstadoOfertaTienda.NoDisponible;
                }
            }
        }

        // --- DIBUJO DENTRO DEL CONTROL ---

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

            int w = Width;
            int h = Height;

            // 1. Contenedor Principal
            Rectangle rectCard = new Rectangle(1, 1, w - 3, h - 3);
            using (GraphicsPath pathCard = CrearPathRedondeado(rectCard, 14))
            {
                using (SolidBrush brushBg = new SolidBrush(Color.White))
                    g.FillPath(brushBg, pathCard);

                using (Pen penBorde = new Pen(ColorBordeGris, 1.2f))
                    g.DrawPath(penBorde, pathCard);
            }

            // 2. Encabezado "Resultados"
            if (!string.IsNullOrEmpty(tituloSeccion))
                g.DrawString(tituloSeccion, FontTitulo, new SolidBrush(ColorTextoOscuro), 18, 14);

            // 3. Nombre y Subtítulo del Producto
            int prodX = 18;
            int prodY = 46;
            g.DrawString(nombreProducto, FontNombreProd, new SolidBrush(ColorTextoOscuro), prodX, prodY);
            g.DrawString(subtituloProducto, FontSubProd, new SolidBrush(ColorTextoGris), prodX, prodY + 22);

            // 4. Tabla de Tiendas (Lado derecho)
            int tableX = 220;
            int tableY = 44;
            int tableW = w - tableX - 18;
            int tableH = h - 60;

            Rectangle rectTable = new Rectangle(tableX, tableY, tableW, tableH);
            using (GraphicsPath pathTable = CrearPathRedondeado(rectTable, 10))
            {
                using (SolidBrush brushTableBg = new SolidBrush(Color.White))
                    g.FillPath(brushTableBg, pathTable);

                using (Pen penTableBorde = new Pen(ColorBordeGris, 1f))
                    g.DrawPath(penTableBorde, pathTable);
            }

            // Renderizado de Filas: Tienda (Izquierda) -> Precio (Al lado) -> Estado (Derecha)
            if (tiendas != null && tiendas.Count > 0)
            {
                int rowCount = tiendas.Count;
                float rowHeight = (float)tableH / rowCount;

                for (int i = 0; i < rowCount; i++)
                {
                    float currentY = tableY + (i * rowHeight);
                    ItemTiendaComparacion item = tiendas[i];

                    if (i > 0)
                    {
                        using (Pen penDiv = new Pen(Color.FromArgb(241, 245, 249), 1f))
                            g.DrawLine(penDiv, tableX + 8, currentY, tableX + tableW - 8, currentY);
                    }

                    // 1. Badge de Tienda (Izquierda de la fila)
                    float tiendaX = tableX + 12;
                    float tiendaY = currentY + (rowHeight - 24) / 2;
                    DibujarBadgeNombreTienda(g, item.NombreTienda, tiendaX, tiendaY);

                    // 2. Precio (Inmediatamente al lado de la tienda)
                    float precioX = tableX + 130;
                    string textoPrecio = $"{item.SimboloMoneda} {item.Precio:N2}";
                    g.DrawString(textoPrecio, FontPrecio, new SolidBrush(ColorTextoOscuro), precioX, currentY + (rowHeight - 18) / 2);

                    // 3. Badge de Estado (Extremo derecho de la fila)
                    float estadoX = tableX + tableW - 105;
                    float estadoY = currentY + (rowHeight - 22) / 2;
                    DibujarBadgeEstadoOferta(g, item.Estado, estadoX, estadoY);
                }
            }
        }

        // Insignias para La Curacao, GCM, SICSA
        private void DibujarBadgeNombreTienda(Graphics g, string nombreTienda, float x, float y)
        {
            RectangleF rect = new RectangleF(x, y, 105, 24);
            Color bg, border, text;

            string nombreUpper = (nombreTienda ?? string.Empty).ToUpper().Trim();

            if (nombreUpper.Contains("CURACAO"))
            {
                bg = Color.FromArgb(254, 240, 138);
                border = Color.FromArgb(234, 179, 8);
                text = Color.FromArgb(113, 63, 18);
            }
            else if (nombreUpper.Contains("GCM"))
            {
                bg = Color.FromArgb(220, 252, 231);
                border = Color.FromArgb(34, 197, 94);
                text = Color.FromArgb(22, 101, 52);
            }
            else if (nombreUpper.Contains("SICSA"))
            {
                bg = Color.FromArgb(224, 242, 254);
                border = Color.FromArgb(56, 189, 248);
                text = Color.FromArgb(3, 105, 161);
            }
            else
            {
                bg = Color.FromArgb(241, 245, 249);
                border = Color.FromArgb(203, 213, 225);
                text = Color.FromArgb(51, 65, 85);
            }

            using (GraphicsPath path = CrearPathRedondeadoF(rect, 10))
            {
                using (SolidBrush brushBg = new SolidBrush(bg))
                    g.FillPath(brushBg, path);

                using (Pen penBorder = new Pen(border, 1f))
                    g.DrawPath(penBorder, path);

                TextRenderer.DrawText(g, nombreTienda, FontBadgeTienda, new Rectangle((int)x, (int)y, 105, 24), text,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter | TextFormatFlags.EndEllipsis);
            }
        }

        private void DibujarBadgeEstadoOferta(Graphics g, EstadoOfertaTienda estado, float x, float y)
        {
            RectangleF rect = new RectangleF(x, y, 95, 22);
            Color colorBg, colorFg;
            string texto;

            switch (estado)
            {
                case EstadoOfertaTienda.MejorOferta:
                    colorBg = Color.FromArgb(34, 197, 94);
                    colorFg = Color.White;
                    texto = "Mejor oferta";
                    break;
                case EstadoOfertaTienda.NoDisponible:
                    colorBg = Color.FromArgb(254, 226, 226);
                    colorFg = Color.FromArgb(220, 38, 38);
                    texto = "No disponible";
                    break;
                default:
                    colorBg = Color.FromArgb(239, 246, 255);
                    colorFg = Color.FromArgb(37, 99, 235);
                    texto = "En stock";
                    break;
            }

            using (GraphicsPath path = CrearPathRedondeadoF(rect, 11))
            using (SolidBrush brushBg = new SolidBrush(colorBg))
            {
                g.FillPath(brushBg, path);

                using (Pen penArrow = new Pen(colorFg, 1.4f) { StartCap = LineCap.Round, EndCap = LineCap.Round })
                {
                    g.DrawLine(penArrow, x + 10, y + 7, x + 10, y + 15);
                    g.DrawLine(penArrow, x + 7, y + 12, x + 10, y + 15);
                    g.DrawLine(penArrow, x + 13, y + 12, x + 10, y + 15);
                }

                TextRenderer.DrawText(g, texto, FontBadgeEstado, new Rectangle((int)x + 14, (int)y, 78, 22), colorFg,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
            }
        }

        private GraphicsPath CrearPathRedondeado(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int d = radius * 2;
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, d, d, 180, 90);
            path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
            path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);
            path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90);
            path.CloseFigure();
            return path;
        }

        private GraphicsPath CrearPathRedondeadoF(RectangleF rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            float d = radius * 2;
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, d, d, 180, 90);
            path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
            path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);
            path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90);
            path.CloseFigure();
            return path;
        }
    }
}