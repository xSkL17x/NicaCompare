using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace NicaCompare
{
    public enum TipoIconoCampo
    {
        Ninguno,
        Usuario,
        Correo,
        Candado,
        Buscar,
        Telefono,
        Calendario,
        Ubicacion,
        Tarjeta,
        Personalizado
    }

    [DefaultEvent("TextChanged")]
    public class CampoTexto : UserControl
    {
        private TextBox txtInput;
        private bool isFocused = false;

        private TipoIconoCampo tipoIcono = TipoIconoCampo.Usuario;
        private Image iconoPersonalizado;
        private Color borderColor = Color.FromArgb(228, 231, 236);
        private Color borderFocusColor = Color.FromArgb(13, 110, 253);
        private int borderRadius = 12;
        private string placeholderText = "Ingresa tu texto aquí";
        private Color placeholderColor = Color.FromArgb(160, 165, 175);
        private Color colorIcono = Color.FromArgb(130, 138, 150);

        private bool esPassword = false;
        private bool ocultarPassword = true;

        [Category("NicaCompare Custom"), Description("Selecciona el icono a mostrar en el campo")]
        public TipoIconoCampo TipoIcono
        {
            get => tipoIcono;
            set
            {
                tipoIcono = value;
                ActualizarPosicionInput();
                this.Invalidate();
            }
        }

        [Category("NicaCompare Custom"), Description("Imagen personalizada cuando TipoIcono está en Personalizado")]
        public Image IconoPersonalizado
        {
            get => iconoPersonalizado;
            set
            {
                iconoPersonalizado = value;
                this.Invalidate();
            }
        }

        [Category("NicaCompare Custom"), Description("Indica si el campo oculta los caracteres como contraseña")]
        public bool EsPassword
        {
            get => esPassword;
            set
            {
                esPassword = value;
                if (txtInput != null)
                    txtInput.UseSystemPasswordChar = esPassword && ocultarPassword;
                ActualizarPosicionInput();
                this.Invalidate();
            }
        }

        [Category("NicaCompare Custom"), Description("Texto introducido en el campo")]
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

        [Category("NicaCompare Custom"), Description("Texto sugerido cuando el campo está vacío")]
        public string PlaceholderText
        {
            get => placeholderText;
            set { placeholderText = value ?? string.Empty; this.Invalidate(); }
        }

        [Category("NicaCompare Custom"), Description("Radio de las esquinas redondeadas")]
        public int BorderRadius
        {
            get => borderRadius;
            set { borderRadius = value; this.Invalidate(); }
        }

        [Category("NicaCompare Custom"), Description("Color del borde en reposo")]
        public Color BorderColor
        {
            get => borderColor;
            set { borderColor = value; this.Invalidate(); }
        }

        [Category("NicaCompare Custom"), Description("Color del borde al enfocar")]
        public Color BorderFocusColor
        {
            get => borderFocusColor;
            set { borderFocusColor = value; this.Invalidate(); }
        }

        [Category("NicaCompare Custom"), Description("Color de los íconos trazados")]
        public Color ColorIcono
        {
            get => colorIcono;
            set { colorIcono = value; this.Invalidate(); }
        }

        public CampoTexto()
        {
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

            this.BackColor = Color.Transparent;
            this.Size = new Size(320, 48);

            txtInput = new TextBox();
            txtInput.BorderStyle = BorderStyle.None;
            txtInput.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular);
            txtInput.ForeColor = Color.FromArgb(40, 40, 40);
            txtInput.BackColor = Color.White;

            txtInput.Enter += (s, e) => { isFocused = true; this.Invalidate(); };
            txtInput.Leave += (s, e) => { isFocused = false; this.Invalidate(); };
            txtInput.TextChanged += (s, e) => { OnTextChanged(e); this.Invalidate(); };

            this.Controls.Add(txtInput);
            ActualizarPosicionInput();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            ActualizarPosicionInput();
        }

        private void ActualizarPosicionInput()
        {
            if (txtInput != null)
            {
                int posX = (tipoIcono == TipoIconoCampo.Ninguno) ? 14 : 42;
                int marginRight = esPassword ? 36 : 14;
                int ancho = this.Width - posX - marginRight;

                txtInput.Location = new Point(posX, (this.Height - txtInput.Height) / 2);
                txtInput.Width = Math.Max(10, ancho);
            }
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);

            if (esPassword)
            {
                Rectangle rectOjo = new Rectangle(this.Width - 32, (this.Height - 20) / 2, 20, 20);
                if (rectOjo.Contains(e.Location))
                {
                    ocultarPassword = !ocultarPassword;
                    txtInput.UseSystemPasswordChar = ocultarPassword;
                    this.Invalidate();
                    return;
                }
            }

            txtInput.Focus();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rectFondo = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
            Color colorBordeActual = isFocused ? borderFocusColor : borderColor;

            using (GraphicsPath path = GetRoundedPath(rectFondo, borderRadius))
            {
                using (SolidBrush brushFondo = new SolidBrush(Color.White))
                {
                    g.FillPath(brushFondo, path);
                }
                using (Pen penBorde = new Pen(colorBordeActual, isFocused ? 1.8f : 1.2f))
                {
                    g.DrawPath(penBorde, path);
                }
            }

            // Dibujar ícono izquierdo según selección
            Rectangle rectIcono = new Rectangle(12, (this.Height - 20) / 2, 20, 20);

            switch (tipoIcono)
            {
                case TipoIconoCampo.Usuario:
                    DibujarIconoUsuario(g, rectIcono);
                    break;
                case TipoIconoCampo.Correo:
                    DibujarIconoCorreo(g, rectIcono);
                    break;
                case TipoIconoCampo.Candado:
                    DibujarIconoCandado(g, rectIcono);
                    break;
                case TipoIconoCampo.Buscar:
                    DibujarIconoBuscar(g, rectIcono);
                    break;
                case TipoIconoCampo.Telefono:
                    DibujarIconoTelefono(g, rectIcono);
                    break;
                case TipoIconoCampo.Calendario:
                    DibujarIconoCalendario(g, rectIcono);
                    break;
                case TipoIconoCampo.Ubicacion:
                    DibujarIconoUbicacion(g, rectIcono);
                    break;
                case TipoIconoCampo.Tarjeta:
                    DibujarIconoTarjeta(g, rectIcono);
                    break;
                case TipoIconoCampo.Personalizado:
                    if (iconoPersonalizado != null)
                        g.DrawImage(iconoPersonalizado, rectIcono);
                    break;
            }

            // Dibujar ícono de ojo para contraseñas a la derecha
            if (esPassword)
            {
                Rectangle rectOjo = new Rectangle(this.Width - 30, (this.Height - 16) / 2, 18, 16);
                DibujarIconoOjo(g, rectOjo, ocultarPassword);
            }

            // Dibujar placeholder cuando esté vacío y sin foco
            if (string.IsNullOrEmpty(txtInput.Text) && !isFocused)
            {
                Rectangle rectText = new Rectangle(txtInput.Left, 0, txtInput.Width, this.Height);
                TextFormatFlags flags = TextFormatFlags.VerticalCenter | TextFormatFlags.Left | TextFormatFlags.NoPadding;
                TextRenderer.DrawText(g, placeholderText, txtInput.Font, rectText, placeholderColor, flags);
            }
        }

        private void DibujarIconoUsuario(Graphics g, Rectangle rect)
        {
            using (Pen pen = new Pen(colorIcono, 1.8f))
            {
                int headSize = 8;
                int headX = rect.X + (rect.Width - headSize) / 2;
                int headY = rect.Y + 2;
                g.DrawEllipse(pen, headX, headY, headSize, headSize);

                int bodyW = 14;
                int bodyH = 10;
                int bodyX = rect.X + (rect.Width - bodyW) / 2;
                int bodyY = headY + headSize + 2;
                g.DrawArc(pen, bodyX, bodyY, bodyW, bodyH, 180, 180);
            }
        }

        private void DibujarIconoCorreo(Graphics g, Rectangle rect)
        {
            using (Pen pen = new Pen(colorIcono, 1.8f))
            {
                pen.LineJoin = LineJoin.Round;

                int envW = 16;
                int envH = 11;
                int envX = rect.X + (rect.Width - envW) / 2;
                int envY = rect.Y + (rect.Height - envH) / 2;

                g.DrawRectangle(pen, envX, envY, envW, envH);

                Point[] puntosV = {
                    new Point(envX, envY),
                    new Point(envX + (envW / 2), envY + 6),
                    new Point(envX + envW, envY)
                };
                g.DrawLines(pen, puntosV);
            }
        }

        private void DibujarIconoCandado(Graphics g, Rectangle rect)
        {
            using (Pen pen = new Pen(colorIcono, 1.8f))
            {
                int bodyW = 12;
                int bodyH = 9;
                int bodyX = rect.X + (rect.Width - bodyW) / 2;
                int bodyY = rect.Y + 8;

                g.DrawRectangle(pen, bodyX, bodyY, bodyW, bodyH);
                g.DrawArc(pen, bodyX + 2, rect.Y + 2, 8, 10, 180, 180);
            }
        }

        private void DibujarIconoBuscar(Graphics g, Rectangle rect)
        {
            using (Pen pen = new Pen(colorIcono, 1.8f))
            {
                g.DrawEllipse(pen, rect.X + 2, rect.Y + 2, 11, 11);
                g.DrawLine(pen, rect.X + 11, rect.Y + 11, rect.X + 17, rect.Y + 17);
            }
        }

        private void DibujarIconoTelefono(Graphics g, Rectangle rect)
        {
            using (Pen pen = new Pen(colorIcono, 1.8f))
            {
                pen.StartCap = LineCap.Round;
                pen.EndCap = LineCap.Round;
                pen.LineJoin = LineJoin.Round;

                // Puntos anatómicos para un auricular de teléfono equilibrado en 45°
                PointF[] puntos = new PointF[]
                {
            new PointF(rect.X + 4, rect.Y + 7),
            new PointF(rect.X + 7, rect.Y + 4),
            new PointF(rect.X + 10, rect.Y + 7),
            new PointF(rect.X + 8.5f, rect.Y + 8.5f),
            new PointF(rect.X + 11.5f, rect.Y + 11.5f),
            new PointF(rect.X + 13, rect.Y + 10),
            new PointF(rect.X + 16, rect.Y + 13),
            new PointF(rect.X + 13, rect.Y + 16),
            new PointF(rect.X + 8, rect.Y + 14),
            new PointF(rect.X + 6, rect.Y + 12)
                };

                using (GraphicsPath path = new GraphicsPath())
                {
                    path.AddClosedCurve(puntos, 0.3f);
                    g.DrawPath(pen, path);
                }
            }
        }

        private void DibujarIconoCalendario(Graphics g, Rectangle rect)
        {
            using (Pen pen = new Pen(colorIcono, 1.8f))
            {
                int w = 15;
                int h = 13;
                int x = rect.X + (rect.Width - w) / 2;
                int y = rect.Y + (rect.Height - h) / 2 + 1;

                g.DrawRectangle(pen, x, y, w, h);
                g.DrawLine(pen, x, y + 4, x + w, y + 4);
                g.DrawLine(pen, x + 4, y - 2, x + 4, y);
                g.DrawLine(pen, x + 11, y - 2, x + 11, y);
            }
        }

        private void DibujarIconoUbicacion(Graphics g, Rectangle rect)
        {
            using (Pen pen = new Pen(colorIcono, 1.8f))
            {
                pen.LineJoin = LineJoin.Round;
                pen.StartCap = LineCap.Round;
                pen.EndCap = LineCap.Round;

                using (GraphicsPath path = new GraphicsPath())
                {
                    path.AddArc(rect.X + 5, rect.Y + 1, 10, 10, 180, 180);
                    path.AddLine(rect.X + 15, rect.Y + 6, rect.X + 10, rect.Y + 18);
                    path.CloseFigure();
                    g.DrawPath(pen, path);
                }

                using (SolidBrush brush = new SolidBrush(colorIcono))
                {
                    g.FillEllipse(brush, rect.X + 8.5f, rect.Y + 4.5f, 3f, 3f);
                }
            }
        }
        private void DibujarIconoTarjeta(Graphics g, Rectangle rect)
        {
            using (Pen pen = new Pen(colorIcono, 1.8f))
            {
                int w = 17;
                int h = 11;
                int x = rect.X + (rect.Width - w) / 2;
                int y = rect.Y + (rect.Height - h) / 2;

                g.DrawRectangle(pen, x, y, w, h);
                g.DrawLine(pen, x, y + 4, x + w, y + 4);
                g.DrawLine(pen, x + 3, y + 8, x + 7, y + 8);
            }
        }

        private void DibujarIconoOjo(Graphics g, Rectangle rect, bool tachado)
        {
            using (Pen pen = new Pen(colorIcono, 1.5f))
            {
                g.DrawArc(pen, rect.X, rect.Y, rect.Width, rect.Height, 200, 140);
                g.DrawArc(pen, rect.X, rect.Y - 4, rect.Width, rect.Height + 4, 20, 140);
                g.DrawEllipse(pen, rect.X + 6, rect.Y + 4, 6, 6);

                if (tachado)
                {
                    g.DrawLine(pen, rect.X + 1, rect.Y + 14, rect.X + 17, rect.Y + 1);
                }
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