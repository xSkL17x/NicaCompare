using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace NicaCompare
{
    [DefaultEvent("BuscarClicked")]
    public class BarraBusqueda : UserControl
    {
        private TextBox txtInput;
        private bool isFocused = false;
        private bool isButtonHovered = false;
        private bool isButtonPressed = false;

        // Colores y propiedades visuales
        private string placeholderText = "¿Qué producto estás buscando?";
        private Color colorPlaceholder = Color.FromArgb(160, 165, 175);
        private Color colorFondoBarra = Color.White;
        private Color colorBordeBarra = Color.FromArgb(225, 230, 238);

        private Color colorBotonNormal = Color.FromArgb(13, 110, 253);
        private Color colorBotonHover = Color.FromArgb(10, 90, 215);
        private Color colorBotonPressed = Color.FromArgb(8, 70, 180);
        private Color colorTextoBoton = Color.White;
        private Color colorIconoIzquierdo = Color.FromArgb(110, 118, 130);

        private Rectangle rectBotonBusqueda;

        // Evento principal
        public event EventHandler? BuscarClicked;

        [Category("NicaCompare Custom"), Description("Texto ingresado en la barra")]
        public override string Text
        {
            get => txtInput != null ? txtInput.Text : (base.Text ?? string.Empty);
            set
            {
                base.Text = value ?? string.Empty;
                if (txtInput != null) txtInput.Text = value ?? string.Empty;
                this.Invalidate();
            }
        }

        [Category("NicaCompare Custom"), Description("Texto de sugerencia cuando el campo está vacío")]
        public string PlaceholderText
        {
            get => placeholderText;
            set { placeholderText = value ?? string.Empty; this.Invalidate(); }
        }

        [Category("NicaCompare Custom"), Description("Color del botón principal de búsqueda")]
        public Color ColorBoton
        {
            get => colorBotonNormal;
            set { colorBotonNormal = value; this.Invalidate(); }
        }

        public BarraBusqueda()
        {
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

            this.BackColor = Color.Transparent;
            this.Size = new Size(550, 52);
            this.MinimumSize = new Size(200, 40);

            txtInput = new TextBox
            {
                BorderStyle = BorderStyle.None,
                Font = new Font("Segoe UI", 10.5F, FontStyle.Regular),
                ForeColor = Color.FromArgb(40, 40, 40),
                BackColor = Color.White
            };

            txtInput.Enter += (s, e) => { isFocused = true; this.Invalidate(); };
            txtInput.Leave += (s, e) => { isFocused = false; this.Invalidate(); };
            txtInput.TextChanged += (s, e) => { OnTextChanged(e); this.Invalidate(); };
            txtInput.KeyDown += TxtInput_KeyDown;

            this.Controls.Add(txtInput);
            ActualizarPosicionInput();
        }

        private void TxtInput_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                BuscarClicked?.Invoke(this, EventArgs.Empty);
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            ActualizarPosicionInput();
        }

        private void ActualizarPosicionInput()
        {
            if (txtInput == null) return;

            int anchoBoton = 115;
            int margenBoton = 5;

            int altoBoton = Math.Max(10, this.Height - (margenBoton * 2));
            int posXBoton = Math.Max(margenBoton, this.Width - anchoBoton - margenBoton);

            rectBotonBusqueda = new Rectangle(posXBoton, margenBoton, anchoBoton, altoBoton);

            int posX = 44;
            int anchoInput = Math.Max(10, rectBotonBusqueda.Left - posX - 10);

            txtInput.Location = new Point(posX, Math.Max(0, (this.Height - txtInput.Height) / 2));
            txtInput.Width = anchoInput;
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            bool hoverAnterior = isButtonHovered;
            isButtonHovered = rectBotonBusqueda.Contains(e.Location);

            this.Cursor = isButtonHovered ? Cursors.Hand : Cursors.Default;

            if (hoverAnterior != isButtonHovered)
                this.Invalidate();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            if (isButtonHovered)
            {
                isButtonHovered = false;
                this.Cursor = Cursors.Default;
                this.Invalidate();
            }
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);

            if (rectBotonBusqueda.Contains(e.Location))
            {
                isButtonPressed = true;
                this.Invalidate();
            }
            else
            {
                txtInput.Focus();
            }
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            if (isButtonPressed)
            {
                isButtonPressed = false;
                this.Invalidate();

                if (rectBotonBusqueda.Contains(e.Location))
                {
                    BuscarClicked?.Invoke(this, EventArgs.Empty);
                }
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (this.Width <= 10 || this.Height <= 10) return;

            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

            // 1. Fondo de la barra principal
            Rectangle rectFondo = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
            using (GraphicsPath pathCapsula = GetRoundedPath(rectFondo, rectFondo.Height))
            {
                using (SolidBrush brushFondo = new SolidBrush(colorFondoBarra))
                {
                    g.FillPath(brushFondo, pathCapsula);
                }
                using (Pen penBorde = new Pen(colorBordeBarra, 1.2f))
                {
                    g.DrawPath(penBorde, pathCapsula);
                }
            }

            // 2. Icono de Lupa (Izquierda)
            Rectangle rectLupaIzquierda = new Rectangle(14, Math.Max(0, (this.Height - 18) / 2), 18, 18);
            DibujarLupa(g, rectLupaIzquierda, colorIconoIzquierdo);

            // 3. Botón Azul de Búsqueda
            if (rectBotonBusqueda.Width > 10 && rectBotonBusqueda.Height > 10)
            {
                Color colorActualBoton = isButtonPressed ? colorBotonPressed : (isButtonHovered ? colorBotonHover : colorBotonNormal);

                using (GraphicsPath pathBoton = GetRoundedPath(rectBotonBusqueda, rectBotonBusqueda.Height))
                {
                    using (SolidBrush brushBoton = new SolidBrush(colorActualBoton))
                    {
                        g.FillPath(brushBoton, pathBoton);
                    }
                }

                // Contenido del Botón (Lupa Blanca + Texto "Buscar")
                Rectangle rectLupaBoton = new Rectangle(rectBotonBusqueda.X + 14, rectBotonBusqueda.Y + Math.Max(0, (rectBotonBusqueda.Height - 16) / 2), 16, 16);
                DibujarLupa(g, rectLupaBoton, colorTextoBoton);

                Rectangle rectTextoBoton = new Rectangle(
                    rectLupaBoton.Right + 4,
                    rectBotonBusqueda.Y,
                    Math.Max(10, rectBotonBusqueda.Width - (rectLupaBoton.Right - rectBotonBusqueda.X) - 10),
                    rectBotonBusqueda.Height
                );

                using (Font fontBoton = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold))
                {
                    TextFormatFlags flagsBoton = TextFormatFlags.VerticalCenter | TextFormatFlags.Left | TextFormatFlags.NoPadding;
                    TextRenderer.DrawText(g, "   Buscar", fontBoton, rectTextoBoton, colorTextoBoton, flagsBoton);
                }
            }

            // 4. Placeholder
            if (string.IsNullOrEmpty(txtInput.Text) && !isFocused)
            {
                Rectangle rectText = new Rectangle(txtInput.Left, 0, txtInput.Width, this.Height);
                TextFormatFlags flags = TextFormatFlags.VerticalCenter | TextFormatFlags.Left | TextFormatFlags.NoPadding;
                TextRenderer.DrawText(g, placeholderText, txtInput.Font, rectText, colorPlaceholder, flags);
            }
        }

        private void DibujarLupa(Graphics g, Rectangle rect, Color color)
        {
            if (rect.Width <= 0 || rect.Height <= 0) return;

            using (Pen pen = new Pen(color, 2.0f))
            {
                pen.StartCap = LineCap.Round;
                pen.EndCap = LineCap.Round;

                int diameter = 10;
                int x = rect.X + (rect.Width - diameter) / 2 - 2;
                int y = rect.Y + (rect.Height - diameter) / 2 - 2;

                g.DrawEllipse(pen, x, y, diameter, diameter);
                g.DrawLine(pen, x + diameter - 1, y + diameter - 1, x + diameter + 5, y + diameter + 5);
            }
        }

        private GraphicsPath GetRoundedPath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();

            // Protección contra dimensiones inválidas de GDI+
            if (rect.Width <= 0 || rect.Height <= 0) return path;

            int size = Math.Min(radius, Math.Min(rect.Width, rect.Height));
            if (size <= 0) size = 1;

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, size, size, 90, 180);
            path.AddArc(rect.Right - size, rect.Y, size, size, 270, 180);
            path.CloseFigure();

            return path;
        }
    }
}