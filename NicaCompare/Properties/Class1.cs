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
    public class TablaResultados : DataGridView
    {
        private readonly Color _borde = Color.FromArgb(203, 213, 225);
        private readonly Color _colorMejor = Color.FromArgb(240, 247, 255);
        private decimal? _min;
        private bool _sucio = true;

        public Dictionary<string, Image> Logos { get; } =
            new Dictionary<string, Image>(StringComparer.OrdinalIgnoreCase);

        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Moneda { get; set; } = "$";

        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool MostrarEncabezados
        {
            get { return ColumnHeadersVisible; }
            set { ColumnHeadersVisible = value; }
        }

        private static readonly string[] _cols =
        {
            "Nombre", "Precio", "Tienda", "Estado"
        };

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
            ColumnHeadersHeightSizeMode =
                DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            ColumnHeadersHeight = 44;

            ColumnHeadersDefaultCellStyle.BackColor =
                Color.FromArgb(248, 250, 252);
            ColumnHeadersDefaultCellStyle.ForeColor =
                Color.FromArgb(71, 85, 105);
            ColumnHeadersDefaultCellStyle.SelectionBackColor =
                Color.FromArgb(248, 250, 252);
            ColumnHeadersDefaultCellStyle.SelectionForeColor =
                Color.FromArgb(71, 85, 105);
            ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 9.5F, FontStyle.Bold);
            ColumnHeadersDefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleLeft;
            ColumnHeadersDefaultCellStyle.Padding = new Padding(10, 0, 0, 0);

            RowTemplate.Height = 58;

            DefaultCellStyle.Font = new Font("Segoe UI", 10F);
            DefaultCellStyle.ForeColor = Color.FromArgb(15, 23, 42);
            DefaultCellStyle.BackColor = Color.White;
            DefaultCellStyle.SelectionBackColor = Color.White;
            DefaultCellStyle.SelectionForeColor = Color.FromArgb(15, 23, 42);
            DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            DataError += (s, e) => { e.ThrowException = false; };
            CellPainting += Tabla_CellPainting;
            RowsAdded += (s, e) => _sucio = true;
            RowsRemoved += (s, e) => _sucio = true;
            CellValueChanged += (s, e) => _sucio = true;
        }

        private bool ColumnasOk()
        {
            if (Columns.Count != _cols.Length)
                return false;

            for (int i = 0; i < _cols.Length; i++)
            {
                if (Columns[i].Name != _cols[i])
                    return false;
            }

            return true;
        }

        private void AsegurarColumnas()
        {
            if (DesignMode || ColumnasOk())
                return;

            Rows.Clear();
            Columns.Clear();

            Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Nombre",
                HeaderText = "Nombre",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                FillWeight = 100,
                MinimumWidth = 150,
                SortMode = DataGridViewColumnSortMode.NotSortable
            });

            Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Precio",
                HeaderText = "Precio",
                Width = 170,
                SortMode = DataGridViewColumnSortMode.NotSortable
            });

            Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Tienda",
                HeaderText = "Tienda",
                Width = 200,
                SortMode = DataGridViewColumnSortMode.NotSortable
            });

            Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Estado",
                HeaderText = "Disponibilidad",
                Width = 170,
                SortMode = DataGridViewColumnSortMode.NotSortable
            });
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

        public int AgregarFila(string nombre, string precio, string tienda)
        {
            AsegurarColumnas();
            return Rows.Add(nombre, precio, tienda, null);
        }

        public void Limpiar()
        {
            Rows.Clear();
            _min = null;
            _sucio = true;
            Invalidate();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            if (Width < 4 || Height < 4)
                return;

            using (var p = CrearMarco(
                new Rectangle(0, 0, Width - 1, Height - 1), 14))
            {
                Region = new Region(p);
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            using (var p = CrearMarco(
                new Rectangle(0, 0, Width - 2, Height - 2), 14))
            using (var pen = new Pen(_borde, 1.5f))
            {
                e.Graphics.DrawPath(pen, p);
            }
        }

        private static GraphicsPath CrearMarco(Rectangle r, int radio)
        {
            int d = Math.Max(2, Math.Min(radio * 2,
                Math.Min(r.Width, r.Height)));

            var p = new GraphicsPath();

            p.AddArc(r.X, r.Y, d, d, 180, 90);
            p.AddArc(r.Right - d, r.Y, d, d, 270, 90);
            p.AddArc(r.Right - d, r.Bottom - d, d, d, 0, 90);
            p.AddArc(r.X, r.Bottom - d, d, d, 90, 90);
            p.CloseFigure();

            return p;
        }

        private static decimal? LeerPrecio(object valor)
        {
            if (valor == null)
                return null;

            string texto = valor.ToString().Trim();

            if (texto.Length == 0)
                return null;

            var m = Regex.Match(texto, @"\d[\d,]*\.?\d*");

            if (!m.Success)
                return null;

            return decimal.TryParse(
                m.Value.Replace(",", ""),
                NumberStyles.Any,
                CultureInfo.InvariantCulture,
                out decimal resultado)
                ? resultado
                : (decimal?)null;
        }

        private void Recalcular()
        {
            var precios = Rows.Cast<DataGridViewRow>()
                .Where(r => !r.IsNewRow)
                .Select(r => LeerPrecio(r.Cells["Precio"].Value))
                .Where(p => p.HasValue && p.Value > 0)
                .Select(p => p.Value)
                .ToList();

            _min = precios.Count > 0
                ? precios.Min()
                : (decimal?)null;

            _sucio = false;
        }

        private string EstadoDe(int fila)
        {
            decimal? precio = LeerPrecio(Rows[fila].Cells["Precio"].Value);

            if (!precio.HasValue || precio.Value <= 0)
                return "No disponible";

            if (_min.HasValue && precio.Value == _min.Value)
                return "Mejor oferta";

            return "En stock";
        }

        private Image BuscarLogo(string tienda)
        {
            foreach (var kv in Logos)
            {
                if (!string.IsNullOrEmpty(tienda) &&
                    tienda.IndexOf(kv.Key,
                        StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    return kv.Value;
                }
            }

            return null;
        }

        private void Tabla_CellPainting(
            object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            if (_sucio)
                Recalcular();

            string col = Columns[e.ColumnIndex].Name;
            string valor = (e.Value ?? "").ToString().Trim();
            string estado = EstadoDe(e.RowIndex);

            if (estado == "Mejor oferta")
            {
                e.CellStyle.BackColor = _colorMejor;
                e.CellStyle.SelectionBackColor = _colorMejor;
            }

            const DataGridViewPaintParts sinTexto =
                DataGridViewPaintParts.All &
                ~DataGridViewPaintParts.ContentForeground;

            switch (col)
            {
                case "Nombre":
                    e.Paint(e.CellBounds, sinTexto);

                    using (var f = new Font("Segoe UI", 10F))
                    {
                        TextRenderer.DrawText(
                            e.Graphics,
                            valor,
                            f,
                            new Rectangle(
                                e.CellBounds.X + 10,
                                e.CellBounds.Y + 6,
                                e.CellBounds.Width - 20,
                                e.CellBounds.Height - 12),
                            Color.FromArgb(15, 23, 42),
                            TextFormatFlags.Left |
                            TextFormatFlags.VerticalCenter |
                            TextFormatFlags.WordBreak |
                            TextFormatFlags.EndEllipsis |
                            TextFormatFlags.NoPadding);
                    }

                    e.Handled = true;
                    break;

                case "Precio":
                    e.Paint(e.CellBounds, sinTexto);
                    DibujarPrecio(e.Graphics, valor, e.CellBounds);
                    e.Handled = true;
                    break;

                case "Tienda":
                    e.Paint(e.CellBounds, sinTexto);
                    DibujarTienda(e.Graphics, valor, e.CellBounds);
                    e.Handled = true;
                    break;

                case "Estado":
                    e.Paint(e.CellBounds, sinTexto);
                    DibujarBadge(e.Graphics, estado, e.CellBounds);
                    e.Handled = true;
                    break;
            }
        }

        private void DibujarPrecio(
            Graphics g, string texto, Rectangle b)
        {
            var flags =
                TextFormatFlags.Left |
                TextFormatFlags.VerticalCenter |
                TextFormatFlags.NoPadding |
                TextFormatFlags.NoPrefix;

            var m = Regex.Match(
                texto,
                @"^(.*?)(\s*\+\s*IVA.*)?$",
                RegexOptions.IgnoreCase);

            string principal = m.Groups[1].Value.Trim();
            string extra = m.Groups[2].Value.Trim();
            bool sinPrecio = LeerPrecio(texto) == null;
            int x = b.X + 10;

            using (var fMain = new Font(
                "Segoe UI",
                sinPrecio ? 10F : 12F,
                sinPrecio ? FontStyle.Regular : FontStyle.Bold))
            using (var fExtra = new Font("Segoe UI", 8.5F))
            {
                Color color = sinPrecio
                    ? Color.FromArgb(100, 116, 139)
                    : Color.FromArgb(15, 23, 42);

                int ancho = TextRenderer.MeasureText(
                    g, principal, fMain, new Size(500, 40),
                    TextFormatFlags.NoPadding).Width;

                TextRenderer.DrawText(
                    g, principal, fMain,
                    new Rectangle(x, b.Y, ancho + 4, b.Height),
                    color, flags);

                if (!sinPrecio && extra.Length > 0)
                {
                    TextRenderer.DrawText(
                        g, extra, fExtra,
                        new Rectangle(
                            x + ancho + 4,
                            b.Y + 2,
                            Math.Max(10, b.Right - x - ancho - 8),
                            b.Height),
                        Color.FromArgb(100, 116, 139),
                        flags | TextFormatFlags.EndEllipsis);
                }
            }
        }

        private void DibujarTienda(
            Graphics g, string tienda, Rectangle b)
        {
            const int anchoLogo = 64;
            const int altoLogo = 28;
            const int margen = 10;

            Image img = BuscarLogo(tienda);
            int xTexto = b.X + margen;

            if (img != null)
            {
                float escala = Math.Min(
                    (float)anchoLogo / img.Width,
                    (float)altoLogo / img.Height);

                int w = (int)(img.Width * escala);
                int h = (int)(img.Height * escala);

                g.InterpolationMode =
                    InterpolationMode.HighQualityBicubic;

                g.DrawImage(
                    img,
                    b.X + margen + (anchoLogo - w) / 2,
                    b.Y + (b.Height - h) / 2,
                    w, h);

                xTexto = b.X + margen + anchoLogo + 10;
            }

            using (var f = new Font("Segoe UI", 10F))
            {
                TextRenderer.DrawText(
                    g, tienda, f,
                    new Rectangle(
                        xTexto, b.Y,
                        Math.Max(10, b.Right - xTexto - 6),
                        b.Height),
                    Color.FromArgb(15, 23, 42),
                    TextFormatFlags.Left |
                    TextFormatFlags.VerticalCenter |
                    TextFormatFlags.EndEllipsis |
                    TextFormatFlags.NoPadding);
            }
        }

        private void DibujarBadge(
            Graphics g, string estado, Rectangle bounds)
        {
            g.SmoothingMode = SmoothingMode.AntiAlias;

            Color fondo, texto;
            string icono;

            if (estado == "Mejor oferta")
            {
                fondo = Color.FromArgb(22, 163, 74);
                texto = Color.White;
                icono = "↓";
            }
            else if (estado == "No disponible")
            {
                fondo = Color.FromArgb(254, 226, 226);
                texto = Color.FromArgb(185, 28, 28);
                icono = "✕";
            }
            else
            {
                fondo = Color.FromArgb(219, 234, 254);
                texto = Color.FromArgb(30, 64, 175);
                icono = "✓";
            }

            using (Font fTxt = new Font("Segoe UI", 9F))
            using (Font fIco = new Font(
                "Segoe UI Symbol", 8.5F, FontStyle.Bold))
            {
                const TextFormatFlags flags =
                    TextFormatFlags.NoPadding |
                    TextFormatFlags.VerticalCenter |
                    TextFormatFlags.Left;

                int wIco = TextRenderer.MeasureText(
                    g, icono, fIco, new Size(100, 30),
                    TextFormatFlags.NoPadding).Width;

                int wTxt = TextRenderer.MeasureText(
                    g, estado, fTxt, new Size(300, 30),
                    TextFormatFlags.NoPadding).Width;

                int h = 26;
                int w = 14 + wIco + 6 + wTxt + 14;

                var r = new Rectangle(
                    bounds.X + 10,
                    bounds.Y + (bounds.Height - h) / 2,
                    w, h);

                using (var p = CrearMarco(r, h / 2))
                using (var br = new SolidBrush(fondo))
                {
                    g.FillPath(br, p);
                }

                TextRenderer.DrawText(
                    g, icono, fIco,
                    new Rectangle(r.X + 14, r.Y, wIco + 2, h),
                    texto, flags);

                TextRenderer.DrawText(
                    g, estado, fTxt,
                    new Rectangle(
                        r.X + 14 + wIco + 6,
                        r.Y, wTxt + 4, h),
                    texto, flags);
            }
        }
    }
}