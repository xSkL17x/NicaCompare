using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace NicaCompare
{
    public class BotonAccion : Button
    {
        private bool isHovered = false;
        private bool isPressed = false;

        private int borderRadius = 12;
        private Color colorNormal = Color.FromArgb(255, 122, 0);   // Naranja vibrante
        private Color colorHover = Color.FromArgb(235, 105, 0);    // Naranja más oscuro al pasar cursor
        private Color colorPressed = Color.FromArgb(210, 90, 0);    // Naranja intenso al dar clic
        private Color colorTexto = Color.White;
        private bool mostrarFlecha = true;

        [Category("NicaCompare Custom"), Description("Muestra u oculta la flecha a la derecha")]
        public bool MostrarFlecha
        {
            get => mostrarFlecha;
            set { mostrarFlecha = value; this.Invalidate(); }
        }

        [Category("NicaCompare Custom"), Description("Color principal del botón")]
        public Color ColorNormal
        {
            get => colorNormal;
            set { colorNormal = value; this.Invalidate(); }
        }

        [Category("NicaCompare Custom"), Description("Radio de curvatura de los bordes")]
        public int BorderRadius
        {
            get => borderRadius;
            set { borderRadius = value; this.Invalidate(); }
        }

        public BotonAccion()
        {
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.FlatAppearance.MouseDownBackColor = Color.Transparent;
            this.FlatAppearance.MouseOverBackColor = Color.Transparent;

            this.BackColor = Color.Transparent;
            this.ForeColor = colorTexto;
            this.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.Size = new Size(320, 48);
            this.Cursor = Cursors.Hand;
            this.Text = "CREAR CUENTA";
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            isHovered = true;
            this.Invalidate();
        }

        protected override void OnMouseLeave(EventArgs e)
        { base.OnMouseLeave(e); isHovered = false; isPressed = false; this.Invalidate(); }

        protected override void OnMouseDown(MouseEventArgs mevent)
        { base.OnMouseDown(mevent); isPressed = true; this.Invalidate(); }

        protected override void OnMouseUp(MouseEventArgs mevent)
        { base.OnMouseUp(mevent); isPressed = false; this.Invalidate(); }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaintBackground(pevent);
            Graphics g = pevent.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

            Rectangle rect = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
            Color colorFondoActual = isPressed ? colorPressed : (isHovered ? colorHover : colorNormal);

            // 1. Dibujar Fondo Redondeado
            using (GraphicsPath path = GetRoundedPath(rect, borderRadius))
            {
                using (SolidBrush brush = new SolidBrush(colorFondoActual))
                {
                    g.FillPath(brush, path);
                }
            }

            // 2. Dibujar Texto Centrado
            if (!string.IsNullOrEmpty(this.Text))
            {
                TextFormatFlags flags = TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter | TextFormatFlags.NoPadding;
                TextRenderer.DrawText(g, this.Text, this.Font, rect, colorTexto, flags);
            }

            // 3. Dibujar Flecha Vectorial (Derecha)
            if (mostrarFlecha)
            {
                DibujarFlecha(g, rect);
            }
        }

        private void DibujarFlecha(Graphics g, Rectangle rect)
        {
            using (Pen pen = new Pen(colorTexto, 2.2f))
            {
                pen.StartCap = LineCap.Round;
                pen.EndCap = LineCap.Round;

                int xFin = rect.Right - 22;
                int xInicio = xFin - 14;
                int yCentro = rect.Y + (rect.Height / 2);

                // Línea horizontal
                g.DrawLine(pen, xInicio, yCentro, xFin, yCentro);

                // Cabeza de la flecha
                g.DrawLine(pen, xFin - 5, yCentro - 5, xFin, yCentro);
                g.DrawLine(pen, xFin - 5, yCentro + 5, xFin, yCentro);
            }
        }

        private GraphicsPath GetRoundedPath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            float size = radius * 2F;
            if (size > rect.Height) size = rect.Height;
            if (size > rect.Width) size = rect.Width;

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, size, size, 180, 90);
            path.AddArc(rect.Right - size, rect.Y, size, size, 270, 90);
            path.AddArc(rect.Right - size, rect.Bottom - size, size, size, 0, 90);
            path.AddArc(rect.X, rect.Bottom - size, size, size, 90, 90);
            path.CloseFigure();
            return path;
        }
    }
}