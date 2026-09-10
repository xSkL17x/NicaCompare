using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace NicaCompare
{
    public enum TipoIconoCampo
    {
        Usuario,
        Correo,
        Buscar,

        Ninguno
    }

    [DefaultEvent("TextChanged")]
    public class CampoTexto : UserControl
    {
        private TextBox txtInput;
        private bool isFocused = false;

        private TipoIconoCampo tipoIcono = TipoIconoCampo.Usuario;
        private Color borderColor = Color.FromArgb(228, 231, 236);      
        private Color borderFocusColor = Color.FromArgb(13, 110, 253);  
        private int borderRadius = 12;
        private string placeholderText = "Ingresa tu texto aquí";
        private Color placeholderColor = Color.FromArgb(160, 165, 175);
        private Color colorIcono = Color.FromArgb(130, 138, 150);

 

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
                int ancho = this.Width - posX - 14;

                txtInput.Location = new Point(posX, (this.Height - txtInput.Height) / 2);
                txtInput.Width = Math.Max(10, ancho);
            }
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
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

            
            Rectangle rectIcono = new Rectangle(12, (this.Height - 20) / 2, 20, 20);

            if (tipoIcono == TipoIconoCampo.Usuario)
            {
                DibujarIconoUsuario(g, rectIcono);
            }
            else if (tipoIcono == TipoIconoCampo.Correo)
            {
                DibujarIconoCorreo(g, rectIcono);
            }

           
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