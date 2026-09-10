using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace NicaCompare
{
    [DefaultEvent("TextChanged")]
    public class CampoPassword : UserControl
    {
        private TextBox txtInput;
        private bool mostrarContraseña = false;
        private bool isFocused = false;

        private Color borderColor = Color.FromArgb(228, 231, 236);     
        private Color borderFocusColor = Color.FromArgb(13, 110, 253); 
        private int borderRadius = 12;
        private string placeholderText = "Confirma tu contraseña";
        private Color placeholderColor = Color.FromArgb(160, 165, 175);
        private Color colorIconos = Color.FromArgb(130, 138, 150);

    

        [Category("NicaCompare Custom"), Description("Texto del campo de contraseña")]
        public override string? Text
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

        [Category("NicaCompare Custom"), Description("Color del borde al hacer clic")]
        public Color BorderFocusColor
        {
            get => borderFocusColor;
            set { borderFocusColor = value; this.Invalidate(); }
        }

        public CampoPassword()
        {
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

            this.BackColor = Color.Transparent;
            this.Size = new Size(320, 48);
            this.Padding = new Padding(10);

           
            txtInput = new TextBox();
            txtInput.BorderStyle = BorderStyle.None;
            txtInput.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular);
            txtInput.ForeColor = Color.FromArgb(40, 40, 40);
            txtInput.BackColor = Color.White;
            txtInput.UseSystemPasswordChar = true;

           
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
                txtInput.Location = new Point(42, (this.Height - txtInput.Height) / 2);
                txtInput.Width = Math.Max(10, this.Width - 82);
            }
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);

            
            Rectangle rectOjo = new Rectangle(this.Width - 40, 0, 40, this.Height);
            if (rectOjo.Contains(e.Location))
            {
                mostrarContraseña = !mostrarContraseña;
                txtInput.UseSystemPasswordChar = !mostrarContraseña;
                this.Invalidate();
            }
            else
            {
                txtInput.Focus();
            }
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

           
            DibujarCandado(g, new Rectangle(12, (this.Height - 20) / 2, 20, 20));

           
            DibujarOjo(g, new Rectangle(this.Width - 32, (this.Height - 20) / 2, 20, 20), !mostrarContraseña);

           
            if (string.IsNullOrEmpty(txtInput.Text) && !isFocused)
            {
                Rectangle rectText = new Rectangle(txtInput.Left, 0, txtInput.Width, this.Height);
                TextFormatFlags flags = TextFormatFlags.VerticalCenter | TextFormatFlags.Left | TextFormatFlags.NoPadding;
                TextRenderer.DrawText(g, placeholderText, txtInput.Font, rectText, placeholderColor, flags);
            }
        }

     

        private void DibujarCandado(Graphics g, Rectangle rect)
        {
            using (Pen pen = new Pen(colorIconos, 1.8f))
            {
                int bodyW = 14;
                int bodyH = 10;
                int bodyX = rect.X + (rect.Width - bodyW) / 2;
                int bodyY = rect.Y + (rect.Height - bodyH) / 2 + 3;

                
                g.DrawRectangle(pen, bodyX, bodyY, bodyW, bodyH);

               
                int shackleW = 8;
                int shackleH = 8;
                int shackleX = rect.X + (rect.Width - shackleW) / 2;
                int shackleY = bodyY - shackleH + 1;
                g.DrawArc(pen, shackleX, shackleY, shackleW, shackleH * 2, 180, 180);
            }
        }

        private void DibujarOjo(Graphics g, Rectangle rect, bool tachado)
        {
            using (Pen pen = new Pen(colorIconos, 1.8f))
            {
                int w = 18;
                int h = 12;
                int x = rect.X + (rect.Width - w) / 2;
                int y = rect.Y + (rect.Height - h) / 2;

                
                g.DrawArc(pen, x, y - 2, w, h + 2, 210, 120);
                g.DrawArc(pen, x, y - 6, w, h + 2, 30, 120);

               
                int pSize = 4;
                g.DrawEllipse(pen, x + (w - pSize) / 2, y + (h - pSize) / 2, pSize, pSize);

               
                if (tachado)
                {
                    g.DrawLine(pen, x - 1, y + h + 1, x + w + 1, y - 3);
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