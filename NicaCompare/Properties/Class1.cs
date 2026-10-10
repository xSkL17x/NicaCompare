using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace NicaCompare
{
    internal static class Formas
    {
        public static GraphicsPath Redondeado(Rectangle r, int radio)
        {
            int d = Math.Max(2, radio * 2);
            var p = new GraphicsPath();
            p.AddArc(r.X, r.Y, d, d, 180, 90);
            p.AddArc(r.Right - d, r.Y, d, d, 270, 90);
            p.AddArc(r.Right - d, r.Bottom - d, d, d, 0, 90);
            p.AddArc(r.X, r.Bottom - d, d, d, 90, 90);
            p.CloseFigure();
            return p;
        }
    }

    // ================= Marco redondeado de la foto =================
    internal class MarcoFoto : Control
    {
        private Image _imagen;
        public Image Imagen { get { return _imagen; } set { _imagen = value; Invalidate(); } }

        public MarcoFoto()
        {
            DoubleBuffered = true;
            ResizeRedraw = true;
            BackColor = Color.White;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            var g = e.Graphics;
            g.Clear(BackColor);
            g.SmoothingMode = SmoothingMode.AntiAlias;

            var externo = new Rectangle(0, 0, Width - 1, Height - 1);
            using (var p = Formas.Redondeado(externo, 16))
            {
                using (var b = new SolidBrush(Color.White)) g.FillPath(b, p);
                using (var pen = new Pen(Color.FromArgb(203, 213, 225), 1.5f)) g.DrawPath(pen, p);
            }

            var interior = Rectangle.Inflate(externo, -10, -10);
            using (var p = Formas.Redondeado(interior, 12))
            {
                using (var b = new SolidBrush(Color.FromArgb(241, 245, 249))) g.FillPath(b, p);

                if (_imagen != null)
                {
                    var area = Rectangle.Inflate(interior, -6, -6);
                    float k = Math.Min((float)area.Width / _imagen.Width, (float)area.Height / _imagen.Height);
                    int w = (int)(_imagen.Width * k), h = (int)(_imagen.Height * k);

                    var estado = g.Save();
                    g.SetClip(p, CombineMode.Intersect);
                    g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                    g.DrawImage(_imagen, area.X + (area.Width - w) / 2, area.Y + (area.Height - h) / 2, w, h);
                    g.Restore(estado);
                }
                else
                {
                    // Ícono de foto para que se vea el espacio reservado
                    int w = 64, h = 48;
                    int x = interior.X + (interior.Width - w) / 2;
                    int y = interior.Y + (interior.Height - h) / 2;
                    using (var pen = new Pen(Color.FromArgb(160, 174, 192), 2f))
                    using (var cuadro = Formas.Redondeado(new Rectangle(x, y, w, h), 6))
                    {
                        pen.LineJoin = LineJoin.Round;
                        g.DrawPath(pen, cuadro);
                        g.DrawEllipse(pen, x + 12, y + 9, 9, 9);
                        g.DrawLines(pen, new[]
                        {
                            new Point(x + 5, y + h - 8), new Point(x + 22, y + 26),
                            new Point(x + 36, y + 38), new Point(x + 45, y + 29),
                            new Point(x + w - 5, y + h - 8)
                        });
                    }
                }
            }
        }
    }

    // ================= TABLA: [Foto + nombre arriba] | Nombre | Precio | Tienda | Disponibilidad =================
    public class TablaResultados : DataGridView
    {
        private const int AnchoFoto = 270;      // zona izquierda
        private const int RadioMarco = 14;

        private readonly MarcoFoto marco = new MarcoFoto();
        private readonly Label lblProducto = new Label();

        private readonly Color _borde = Color.FromArgb(203, 213, 225);
        private readonly Color _colorMejor = Color.FromArgb(240, 247, 255);
        private decimal? _min;
        private bool _sucio = true;

        public Dictionary<string, Image> Logos { get; } =
            new Dictionary<string, Image>(StringComparer.OrdinalIgnoreCase);

        // ----- Lo que tú vas a usar -----
        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string NombreProducto
        {
            get { return lblProducto.Text; }
            set { lblProducto.Text = value; }
        }

        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Image Foto
        {
            get { return marco.Imagen; }
            set { marco.Imagen = value; }
        }

        // Compatibilidad con el diseñador
        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Moneda { get; set; } = "$";

        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool MostrarEncabezados
        {
            get { return ColumnHeadersVisible; }
            set { ColumnHeadersVisible = value; }
        }

        public TablaResultados()
        {
            RightToLeft = RightToLeft.No;
            DoubleBuffered = true;
            ResizeRedraw = true;
            BorderStyle = BorderStyle.None;
            CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            GridColor = Color.FromArgb(226, 232, 240);
            BackgroundColor = Color.White;
            RowHeadersVisible = false;
            AllowUserToAddRows = false;
            AllowUserToDeleteRows = false;
            AllowUserToResizeRows = false;
            AllowUserToResizeColumns = false;
            ReadOnly = true;
            MultiSelect = false;
            AutoGenerateColumns = false;
            ScrollBars = ScrollBars.Vertical;
            TabStop = false;

            EnableHeadersVisualStyles = false;
            ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            ColumnHeadersHeight = 44;
            ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(248, 250, 252);
            ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(71, 85, 105);
            ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(248, 250, 252);
            ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.FromArgb(71, 85, 105);
            ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            ColumnHeadersDefaultCellStyle.Padding = new Padding(10, 0, 0, 0);

            RowTemplate.Height = 58;
            DefaultCellStyle.Font = new Font("Segoe UI", 10F);
            DefaultCellStyle.ForeColor = Color.FromArgb(15, 23, 42);
            DefaultCellStyle.BackColor = Color.White;
            DefaultCellStyle.SelectionBackColor = Color.White;
            DefaultCellStyle.SelectionForeColor = Color.FromArgb(15, 23, 42);
            DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            // Nombre del producto (arriba de la foto)
            lblProducto.Text = "Producto";
            lblProducto.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblProducto.ForeColor = Color.FromArgb(15, 23, 60);
            lblProducto.BackColor = Color.White;
            lblProducto.AutoEllipsis = true;
            lblProducto.TextAlign = ContentAlignment.MiddleLeft;
            Controls.Add(lblProducto);
            Controls.Add(marco);

            // OJO: las columnas NO se crean aquí (así el diseñador no las guarda y no salen dobles)
            DataError += (s, e) => { e.ThrowException = false; };
            CellPainting += Tabla_CellPainting;
            RowsAdded += (s, e) => _sucio = true;
            RowsRemoved += (s, e) => _sucio = true;
            CellValueChanged += (s, e) => _sucio = true;
        }

        // ---------- Columnas (se crean al ejecutar y se limpian duplicados) ----------
        private static readonly string[] _cols = { "Nombre", "Precio", "Tienda", "Estado", "Foto" };

        private bool ColumnasOk()
        {
            if (Columns.Count != _cols.Length) return false;
            for (int i = 0; i < _cols.Length; i++)
                if (Columns[i].Name != _cols[i]) return false;
            return true;
        }

        private void AsegurarColumnas()
        {
            if (DesignMode || ColumnasOk()) return;

            Rows.Clear();
            Columns.Clear();

            Columns.Add(new DataGridViewTextBoxColumn
            { Name = "Nombre", HeaderText = "Nombre", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill, FillWeight = 100, MinimumWidth = 150, SortMode = DataGridViewColumnSortMode.NotSortable });
            Columns.Add(new DataGridViewTextBoxColumn
            { Name = "Precio", HeaderText = "Precio", Width = 170, SortMode = DataGridViewColumnSortMode.NotSortable });
            Columns.Add(new DataGridViewTextBoxColumn
            { Name = "Tienda", HeaderText = "Tienda", Width = 200, SortMode = DataGridViewColumnSortMode.NotSortable });
            Columns.Add(new DataGridViewTextBoxColumn
            { Name = "Estado", HeaderText = "Disponibilidad", Width = 170, SortMode = DataGridViewColumnSortMode.NotSortable });
            Columns.Add(new DataGridViewTextBoxColumn
            { Name = "Foto", HeaderText = "", Width = AnchoFoto, Resizable = DataGridViewTriState.False, SortMode = DataGridViewColumnSortMode.NotSortable });

            // La zona de la foto va a la izquierda, pero los datos siguen entrando en el mismo orden:
            // Rows.Add(nombre, precio, tienda)
            Columns["Foto"].DisplayIndex = 0;
            PosicionarMarco();
        }

        protected override void OnParentChanged(EventArgs e)
        {
            base.OnParentChanged(e);
            AsegurarColumnas();
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            AsegurarColumnas();
        }

        // Puedes usar Rows.Add(nombre, precio, tienda) o este método
        public int AgregarFila(string nombre, string precio, string tienda)
        {
            AsegurarColumnas();
            return Rows.Add(nombre, precio, tienda, null);
        }

        public void Limpiar()
        {
            Rows.Clear();
        }

        // ---------- Posición del marco de la foto ----------
        private void PosicionarMarco()
        {
            int header = ColumnHeadersHeight;
            int lado = Math.Max(100, Math.Min(AnchoFoto - 30, ClientSize.Height - header - 22));
            lblProducto.SetBounds(14, 6, AnchoFoto - 28, header - 10);
            marco.SetBounds(14, header + 10, lado, lado);
        }

        // ---------- Marco redondeado de toda la tabla ----------
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            PosicionarMarco();
            if (Width < 4 || Height < 4) return;
            using (var p = Formas.Redondeado(new Rectangle(0, 0, Width, Height), RadioMarco))
                Region = new Region(p);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            using (var p = Formas.Redondeado(new Rectangle(0, 0, Width - 2, Height - 2), RadioMarco))
            using (var pen = new Pen(_borde, 1.5f))
                e.Graphics.DrawPath(pen, p);
        }

        // ---------- Precio y estado ----------
        private static decimal? LeerPrecio(object valor)
        {
            if (valor == null) return null;
            var m = Regex.Match(valor.ToString(), @"\d[\d,]*\.?\d*");
            if (!m.Success) return null;
            return decimal.TryParse(m.Value.Replace(",", ""), NumberStyles.Any,
                CultureInfo.InvariantCulture, out decimal r) ? r : (decimal?)null;
        }

        private void Recalcular()
        {
            _min = Rows.Cast<DataGridViewRow>()
                       .Where(r => !r.IsNewRow)
                       .Select(r => LeerPrecio(r.Cells["Precio"].Value))
                       .Where(p => p.HasValue && p.Value > 0)
                       .Min();
            _sucio = false;
        }

        private string EstadoDe(int fila)
        {
            decimal? p = LeerPrecio(Rows[fila].Cells["Precio"].Value);
            if (!p.HasValue || p.Value <= 0) return "No disponible";
            return p == _min ? "Mejor oferta" : "En stock";
        }

        // ---------- Pintado ----------
        private Image BuscarLogo(string tienda)
        {
            foreach (var kv in Logos)
                if (tienda.IndexOf(kv.Key, StringComparison.OrdinalIgnoreCase) >= 0)
                    return kv.Value;
            return null;
        }

        private void Tabla_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex < 0) return;
            string col = Columns[e.ColumnIndex].Name;

            // Zona de la foto: fondo blanco liso, sin líneas
            if (col == "Foto")
            {
                using (var b = new SolidBrush(Color.White))
                    e.Graphics.FillRectangle(b, e.CellBounds);
                e.Handled = true;
                return;
            }

            if (e.RowIndex < 0) return;
            if (_sucio) Recalcular();

            string estado = EstadoDe(e.RowIndex);
            if (estado == "Mejor oferta")
            {
                e.CellStyle.BackColor = _colorMejor;
                e.CellStyle.SelectionBackColor = _colorMejor;
            }

            const DataGridViewPaintParts SinTexto =
                DataGridViewPaintParts.All & ~DataGridViewPaintParts.ContentForeground;
            string val = (e.Value ?? "").ToString().Trim();

            switch (col)
            {
                case "Nombre":
                    e.Paint(e.CellBounds, SinTexto);
                    using (var f = new Font("Segoe UI", 10F))
                        TextRenderer.DrawText(e.Graphics, val, f,
                            new Rectangle(e.CellBounds.X + 10, e.CellBounds.Y + 6,
                                          e.CellBounds.Width - 20, e.CellBounds.Height - 12),
                            Color.FromArgb(15, 23, 42),
                            TextFormatFlags.Left | TextFormatFlags.VerticalCenter |
                            TextFormatFlags.WordBreak | TextFormatFlags.EndEllipsis |
                            TextFormatFlags.NoPadding);
                    e.Handled = true;
                    break;

                case "Precio":
                    e.Paint(e.CellBounds, SinTexto);
                    DibujarPrecio(e.Graphics, val, e.CellBounds);
                    e.Handled = true;
                    break;

                case "Tienda":
                    e.Paint(e.CellBounds, SinTexto);
                    DibujarTienda(e.Graphics, val, e.CellBounds);
                    e.Handled = true;
                    break;

                case "Estado":
                    e.Paint(e.CellBounds, SinTexto);
                    DibujarBadge(e.Graphics, estado, e.CellBounds);
                    e.Handled = true;
                    break;
            }
        }

        private void DibujarPrecio(Graphics g, string texto, Rectangle b)
        {
            var flags = TextFormatFlags.Left | TextFormatFlags.VerticalCenter |
                        TextFormatFlags.NoPadding | TextFormatFlags.NoPrefix;

            var m = Regex.Match(texto, @"^(.*?)(\s*\+\s*IVA.*)?$", RegexOptions.IgnoreCase);
            string principal = m.Groups[1].Value.Trim();
            string extra = m.Groups[2].Value.Trim();
            bool sinPrecio = LeerPrecio(texto) == null;
            int x = b.X + 10;

            using (var fMain = new Font("Segoe UI", sinPrecio ? 10F : 12F,
                                        sinPrecio ? FontStyle.Regular : FontStyle.Bold))
            using (var fExtra = new Font("Segoe UI", 8.5F))
            {
                Color cMain = sinPrecio ? Color.FromArgb(100, 116, 139) : Color.FromArgb(15, 23, 42);
                int wMain = TextRenderer.MeasureText(g, principal, fMain, new Size(500, 40),
                                TextFormatFlags.NoPadding).Width;

                TextRenderer.DrawText(g, principal, fMain,
                    new Rectangle(x, b.Y, wMain + 4, b.Height), cMain, flags);

                if (!sinPrecio && extra.Length > 0)
                    TextRenderer.DrawText(g, extra, fExtra,
                        new Rectangle(x + wMain + 4, b.Y + 2, Math.Max(10, b.Right - x - wMain - 8), b.Height),
                        Color.FromArgb(100, 116, 139), flags | TextFormatFlags.EndEllipsis);
            }
        }

        private void DibujarTienda(Graphics g, string tienda, Rectangle b)
        {
            const int anchoLogo = 64, altoLogo = 28, margen = 10;
            Image img = BuscarLogo(tienda);
            int xTexto = b.X + margen;

            if (img != null)
            {
                float k = Math.Min((float)anchoLogo / img.Width, (float)altoLogo / img.Height);
                int w = (int)(img.Width * k), h = (int)(img.Height * k);
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                g.DrawImage(img, b.X + margen + (anchoLogo - w) / 2, b.Y + (b.Height - h) / 2, w, h);
                xTexto = b.X + margen + anchoLogo + 10;
            }

            using (var f = new Font("Segoe UI", 10F))
                TextRenderer.DrawText(g, tienda, f,
                    new Rectangle(xTexto, b.Y, Math.Max(10, b.Right - xTexto - 6), b.Height),
                    Color.FromArgb(15, 23, 42),
                    TextFormatFlags.Left | TextFormatFlags.VerticalCenter |
                    TextFormatFlags.EndEllipsis | TextFormatFlags.NoPadding);
        }

        private void DibujarBadge(Graphics g, string estado, Rectangle bounds)
        {
            g.SmoothingMode = SmoothingMode.AntiAlias;

            Color bg, fg;
            string icono;
            if (estado == "Mejor oferta")
            { bg = Color.FromArgb(22, 163, 74); fg = Color.White; icono = "↓"; }
            else if (estado == "No disponible")
            { bg = Color.FromArgb(254, 226, 226); fg = Color.FromArgb(185, 28, 28); icono = "✕"; }
            else
            { bg = Color.FromArgb(219, 234, 254); fg = Color.FromArgb(30, 64, 175); icono = "✓"; }

            using (Font fTxt = new Font("Segoe UI", 9F))
            using (Font fIco = new Font("Segoe UI Symbol", 8.5F, FontStyle.Bold))
            {
                var flags = TextFormatFlags.NoPadding | TextFormatFlags.VerticalCenter | TextFormatFlags.Left;
                int wIco = TextRenderer.MeasureText(g, icono, fIco, new Size(100, 30), TextFormatFlags.NoPadding).Width;
                int wTxt = TextRenderer.MeasureText(g, estado, fTxt, new Size(300, 30), TextFormatFlags.NoPadding).Width;

                int h = 26, w = 14 + wIco + 6 + wTxt + 14;
                var r = new Rectangle(bounds.X + 10, bounds.Y + (bounds.Height - h) / 2, w, h);

                using (var p = Formas.Redondeado(r, h / 2))
                using (var br = new SolidBrush(bg))
                    g.FillPath(br, p);

                TextRenderer.DrawText(g, icono, fIco, new Rectangle(r.X + 14, r.Y, wIco + 2, h), fg, flags);
                TextRenderer.DrawText(g, estado, fTxt, new Rectangle(r.X + 14 + wIco + 6, r.Y, wTxt + 4, h), fg, flags);
            }
        }
    }
}
