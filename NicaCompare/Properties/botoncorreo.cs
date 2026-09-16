using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
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
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern Int32 SendMessage(IntPtr hWnd, int msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);
        private const int EM_SETCUEBANNER = 0x1501;

        private TextBox txtInput;
        private bool isFocused = false;

        private TipoIconoCampo tipoIcono = TipoIconoCampo.Usuario;
        private Image iconoPersonalizado;
        private Color borderColor = Color.FromArgb(226, 232, 240);          // Borde gris claro
        private Color borderFocusColor = Color.FromArgb(59, 130, 246);     // Borde azul al enfocar
        private Color colorFondoIcono = Color.FromArgb(241, 245, 249);     // Fondo azul/grisáceo del icono ("lo azulito")
        private Color colorIcono = Color.FromArgb(100, 116, 139);         // Color del trazo del icono
        private int borderRadius = 8;

        private string placeholderText = "Tu nombre completo";
        private bool esPlaceholderModificado = false;

        private bool esPassword = false;
        private bool ocultarPassword = true;

        [Category("NicaCompare Custom"), Description("Selecciona el icono a mostrar en el campo")]
        public TipoIconoCampo TipoIcono
        {
            get => tipoIcono;
            set
            {
                tipoIcono = value;
                if (!esPlaceholderModificado)
                {
                    placeholderText = ObtenerPlaceholderPorDefecto(value);
                }
                ActualizarPosicionInput();
                ActualizarCueBanner();
                this.Invalidate();
            }
        }

        [Category("NicaCompare Custom"), Description("Imagen personalizada cuando TipoIcono está en Personalizado")]
        public Image IconoPersonalizado
        {
            get => iconoPersonalizado;
            set { iconoPersonalizado = value; this.Invalidate(); }
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
            set
            {
                placeholderText = value ?? string.Empty;
                esPlaceholderModificado = true;
                ActualizarCueBanner();
                this.Invalidate();
            }
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

        [Category("NicaCompare Custom"), Description("Color de fondo de la sección del icono")]
        public Color ColorFondoIcono
        {
            get => colorFondoIcono;
            set { colorFondoIcono = value; this.Invalidate(); }
        }

        [Category("NicaCompare Custom"), Description("Color del trazo de los iconos")]
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
            this.Size = new Size(340, 44);

            txtInput = new TextBox();
            txtInput.BorderStyle = BorderStyle.None;
            txtInput.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular);
            txtInput.ForeColor = Color.FromArgb(30, 41, 59);
            txtInput.BackColor = Color.White;

            txtInput.Enter += (s, e) => { isFocused = true; this.Invalidate(); };
            txtInput.Leave += (s, e) => { isFocused = false; this.Invalidate(); };
            txtInput.TextChanged += (s, e) => { OnTextChanged(e); };
            txtInput.HandleCreated += (s, e) => { ActualizarCueBanner(); };

            this.Controls.Add(txtInput);
            ActualizarPosicionInput();
        }

        private string ObtenerPlaceholderPorDefecto(TipoIconoCampo tipo)
        {
            switch (tipo)
            {
                case TipoIconoCampo.Usuario: return "Tu nombre completo";
                case TipoIconoCampo.Correo: return "correo@ejemplo.com";
                case TipoIconoCampo.Candado: return "123";
                case TipoIconoCampo.Buscar: return "Buscar...";
                case TipoIconoCampo.Telefono: return "+505 8XX XXX XXX";
                case TipoIconoCampo.Calendario: return "MM / AA";
                case TipoIconoCampo.Ubicacion: return "Dirección, ciudad, departamento";
                case TipoIconoCampo.Tarjeta: return "1234 5678 9012 3456";
                default: return "Ingresa tu texto aquí";
            }
        }

        private void ActualizarCueBanner()
        {
            if (txtInput != null && txtInput.IsHandleCreated)
            {
                SendMessage(txtInput.Handle, EM_SETCUEBANNER, 1, placeholderText);
            }
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
                int posX = (tipoIcono == TipoIconoCampo.Ninguno) ? 12 : 50;
                int marginRight = esPassword ? 36 : 12;
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
                Rectangle rectOjo = new Rectangle(this.Width - 30, (this.Height - 20) / 2, 20, 20);
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

            // 1. Dibujar el fondo general (Blanco)
            using (GraphicsPath mainPath = GetRoundedPath(rectFondo, borderRadius))
            {
                using (SolidBrush brushFondo = new SolidBrush(Color.White))
                {
                    g.FillPath(brushFondo, mainPath);
                }

                // 2. Dibujar el bloque azul/gris del lado izquierdo (si hay icono)
                if (tipoIcono != TipoIconoCampo.Ninguno)
                {
                    int anchoBloqueIcono = 40;
                    Rectangle rectIconoBg = new Rectangle(0, 0, anchoBloqueIcono, this.Height - 1);

                    using (GraphicsPath clipPath = GetRoundedPath(rectFondo, borderRadius))
                    {
                        g.SetClip(clipPath);
                        using (SolidBrush brushIconoBg = new SolidBrush(colorFondoIcono))
                        {
                            g.FillRectangle(brushIconoBg, rectIconoBg);
                        }
                        using (Pen penDivisor = new Pen(borderColor, 1f))
                        {
                            g.DrawLine(penDivisor, anchoBloqueIcono, 0, anchoBloqueIcono, this.Height);
                        }
                        g.ResetClip();
                    }
                }

                // 3. Dibujar el borde redondeado exterior
                using (Pen penBorde = new Pen(colorBordeActual, isFocused ? 1.5f : 1.0f))
                {
                    g.DrawPath(penBorde, mainPath);
                }
            }

            // 4. Dibujar icono correspondiente
            if (tipoIcono != TipoIconoCampo.Ninguno)
            {
                Rectangle rectIcono = new Rectangle(11, (this.Height - 18) / 2, 18, 18);

                switch (tipoIcono)
                {
                    case TipoIconoCampo.Usuario: DibujarIconoUsuario(g, rectIcono); break;
                    case TipoIconoCampo.Correo: DibujarIconoCorreo(g, rectIcono); break;
                    case TipoIconoCampo.Candado: DibujarIconoCandado(g, rectIcono); break;
                    case TipoIconoCampo.Buscar: DibujarIconoBuscar(g, rectIcono); break;
                    case TipoIconoCampo.Telefono: DibujarIconoTelefono(g, rectIcono); break;
                    case TipoIconoCampo.Calendario: DibujarIconoCalendario(g, rectIcono); break;
                    case TipoIconoCampo.Ubicacion: DibujarIconoUbicacion(g, rectIcono); break;
                    case TipoIconoCampo.Tarjeta: DibujarIconoTarjeta(g, rectIcono); break;
                    case TipoIconoCampo.Personalizado:
                        if (iconoPersonalizado != null) g.DrawImage(iconoPersonalizado, rectIcono);
                        break;
                }
            }

            // 5. Dibujar icono de ojo para contraseña
            if (esPassword)
            {
                Rectangle rectOjo = new Rectangle(this.Width - 28, (this.Height - 16) / 2, 18, 16);
                DibujarIconoOjo(g, rectOjo, ocultarPassword);
            }
        }

        private void DibujarIconoUsuario(Graphics g, Rectangle rect)
        {
            using (Pen pen = CrearPenIcono())
            {
                g.DrawEllipse(pen, rect.X + 4, rect.Y + 1, 10, 10);
                g.DrawArc(pen, rect.X + 1, rect.Y + 11, 16, 10, 190, 160);
            }
        }

        private void DibujarIconoCorreo(Graphics g, Rectangle rect)
        {
            using (Pen pen = CrearPenIcono())
            {
                g.DrawRectangle(pen, rect.X + 1, rect.Y + 3, 16, 12);
                g.DrawLine(pen, rect.X + 1, rect.Y + 3, rect.X + 9, rect.Y + 9);
                g.DrawLine(pen, rect.X + 9, rect.Y + 9, rect.X + 17, rect.Y + 3);
            }
        }

        private void DibujarIconoCandado(Graphics g, Rectangle rect)
        {
            using (Pen pen = CrearPenIcono())
            {
                g.DrawRectangle(pen, rect.X + 2, rect.Y + 8, 14, 9);
                g.DrawArc(pen, rect.X + 5, rect.Y + 2, 8, 10, 180, 180);
            }
        }

        private void DibujarIconoBuscar(Graphics g, Rectangle rect)
        {
            using (Pen pen = CrearPenIcono())
            {
                g.DrawEllipse(pen, rect.X + 1, rect.Y + 1, 11, 11);
                g.DrawLine(pen, rect.X + 10, rect.Y + 10, rect.X + 16, rect.Y + 16);
            }
        }

        private void DibujarIconoTelefono(Graphics g, Rectangle rect)
        {
            using (Pen pen = CrearPenIcono())
            {
                // Auricular de teléfono vectorial continuo
                PointF[] pts = new PointF[]
                {
                    new PointF(rect.X + 4, rect.Y + 3),
                    new PointF(rect.X + 7.5f, rect.Y + 3),
                    new PointF(rect.X + 9, rect.Y + 6),
                    new PointF(rect.X + 7.5f, rect.Y + 8),
                    new PointF(rect.X + 10, rect.Y + 10.5f),
                    new PointF(rect.X + 12, rect.Y + 9),
                    new PointF(rect.X + 15, rect.Y + 10.5f),
                    new PointF(rect.X + 15, rect.Y + 14),
                    new PointF(rect.X + 12, rect.Y + 15.5f),
                    new PointF(rect.X + 3, rect.Y + 6.5f)
                };
                using (GraphicsPath path = new GraphicsPath())
                {
                    path.AddClosedCurve(pts, 0.2f);
                    g.DrawPath(pen, path);
                }
            }
        }

        private void DibujarIconoCalendario(Graphics g, Rectangle rect)
        {
            using (Pen pen = CrearPenIcono())
            {
                g.DrawRectangle(pen, rect.X + 1, rect.Y + 3, 16, 13);
                g.DrawLine(pen, rect.X + 1, rect.Y + 7, rect.X + 17, rect.Y + 7);
                g.DrawLine(pen, rect.X + 5, rect.Y + 1, rect.X + 5, rect.Y + 4);
                g.DrawLine(pen, rect.X + 13, rect.Y + 1, rect.X + 13, rect.Y + 4);
            }
        }

        private void DibujarIconoUbicacion(Graphics g, Rectangle rect)
        {
            using (Pen pen = CrearPenIcono())
            {
                using (GraphicsPath path = new GraphicsPath())
                {
                    path.AddArc(rect.X + 4, rect.Y + 1, 10, 10, 180, 180);
                    path.AddLine(rect.X + 14, rect.Y + 6, rect.X + 9, rect.Y + 17);
                    path.CloseFigure();
                    g.DrawPath(pen, path);
                }
                g.DrawEllipse(pen, rect.X + 7.5f, rect.Y + 4.5f, 3f, 3f);
            }
        }

        private void DibujarIconoTarjeta(Graphics g, Rectangle rect)
        {
            using (Pen pen = CrearPenIcono())
            {
                g.DrawRectangle(pen, rect.X + 1, rect.Y + 3, 16, 11);
                g.DrawLine(pen, rect.X + 1, rect.Y + 7, rect.X + 17, rect.Y + 7);
            }
        }

        private void DibujarIconoOjo(Graphics g, Rectangle rect, bool tachado)
        {
            using (Pen pen = new Pen(colorIcono, 1.4f))
            {
                g.DrawArc(pen, rect.X, rect.Y, rect.Width, rect.Height, 200, 140);
                g.DrawArc(pen, rect.X, rect.Y - 4, rect.Width, rect.Height + 4, 20, 140);
                g.DrawEllipse(pen, rect.X + 6, rect.Y + 4, 6, 6);

                if (tachado)
                {
                    g.DrawLine(pen, rect.X + 2, rect.Y + 13, rect.X + 16, rect.Y + 2);
                }
            }
        }

        private Pen CrearPenIcono()
        {
            return new Pen(colorIcono, 1.5f)
            {
                StartCap = LineCap.Round,
                EndCap = LineCap.Round,
                LineJoin = LineJoin.Round
            };
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