using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace NicaCompare
{
    using System;
    using System.Drawing;
    using System.Drawing.Drawing2D;
    using System.Windows.Forms;

    public class BotonCategoriaCheck : Control
    {
        private bool _checked = false;
        private Image _imagen;
        private int _borderRadius = 12;

        private Color _borderSelectedColor = Color.FromArgb(0, 102, 204);
        private Color _borderNormalColor = Color.FromArgb(230, 232, 235);
        private Color _backSelectedColor = Color.FromArgb(240, 247, 255);
        private Color _backNormalColor = Color.White;

        public event EventHandler CheckedChanged;

        public BotonCategoriaCheck()
        {
            SetStyle(ControlStyles.SupportsTransparentBackColor |
                     ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.UserPaint |
                     ControlStyles.ResizeRedraw, true);

            DoubleBuffered = true;
            Size = new Size(120, 110);
            Cursor = Cursors.Hand;
            BackColor = Color.Transparent;
            Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        }

        public bool Checked
        {
            get => _checked;
            set
            {
                if (_checked != value)
                {
                    _checked = value;
                    CheckedChanged?.Invoke(this, EventArgs.Empty);
                    Invalidate();
                }
            }
        }

        public Image Imagen
        {
            get => _imagen;
            set { _imagen = value; Invalidate(); }
        }

        public int BorderRadius
        {
            get => _borderRadius;
            set { _borderRadius = value; Invalidate(); }
        }

        protected override void OnClick(EventArgs e)
        {
            Checked = !Checked; // 1. Cambia el estado primero
            base.OnClick(e);    // 2. Luego dispara el evento Click
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

            Rectangle rect = new Rectangle(0, 0, Width - 1, Height - 1);
            GraphicsPath path = GetRoundedPath(rect, _borderRadius);

            // 1. Fondo (cambia de color si está seleccionado)
            Color currentBack = _checked ? _backSelectedColor : _backNormalColor;
            using (SolidBrush brushBack = new SolidBrush(currentBack))
            {
                g.FillPath(brushBack, path);
            }

            // 2. Borde exterior (cambia de grosor y color si está seleccionado)
            Color currentBorder = _checked ? _borderSelectedColor : _borderNormalColor;
            int borderWidth = _checked ? 2 : 1;
            using (Pen penBorder = new Pen(currentBorder, borderWidth))
            {
                g.DrawPath(penBorder, path);
            }

            // 3. Renderizado de la Imagen
            int imageAreaHeight = (int)(Height * 0.55);
            if (_imagen != null)
            {
                int imgSize = Math.Min(Width - 40, imageAreaHeight);
                int imgX = (Width - imgSize) / 2;
                int imgY = 12;
                g.DrawImage(_imagen, new Rectangle(imgX, imgY, imgSize, imgSize));
            }

            // 4. Renderizado del Texto
            Rectangle textRect = new Rectangle(5, imageAreaHeight, Width - 10, Height - imageAreaHeight);
            using (StringFormat sf = new StringFormat())
            {
                sf.Alignment = StringAlignment.Center;
                sf.LineAlignment = StringAlignment.Center;
                sf.Trimming = StringTrimming.EllipsisCharacter;

                Color textColor = _checked ? _borderSelectedColor : Color.FromArgb(40, 50, 70);
                using (SolidBrush brushText = new SolidBrush(textColor))
                {
                    g.DrawString(Text, Font, brushText, textRect, sf);
                }
            }


        }

        private GraphicsPath GetRoundedPath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            float diameter = radius * 2f;

            path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);
            path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90);
            path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90);
            path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90);
            path.CloseFigure();

            return path;
        }
    }
}