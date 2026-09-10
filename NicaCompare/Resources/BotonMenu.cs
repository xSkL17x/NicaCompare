using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace NicaCompare
{
    public class BotonMenu : Button
    {
        private bool isHovered;
        private bool isPressed;
        private bool esSeleccionado;

        private int borderRadius = 18;
        private Color colorHover = Color.FromArgb(13, 110, 253);
        private Color colorPressed = Color.FromArgb(10, 80, 190);
        private Color colorTextoNormal = Color.FromArgb(70, 70, 70);
        private Color colorTextoHover = Color.White;

        private bool autoEscalarImagen = true;
        private int porcentajeEscalaImagen = 50;
        private int margenImagenIzquierda = 15;
        private bool autoColorearIconoBlanco = true;

        // Caché
        private GraphicsPath cachedPath;
        private Size cachedSize;
        private int cachedRadius;
        private SolidBrush brushFondo;
        private ImageAttributes whiteImageAttr;

        public BotonMenu()
        {
            // Estilos correctos
            SetStyle(ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.UserPaint |
                     ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.ResizeRedraw |
                     ControlStyles.SupportsTransparentBackColor, true);

            SetStyle(ControlStyles.Opaque, false);

            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            FlatAppearance.MouseDownBackColor = Color.Transparent;
            FlatAppearance.MouseOverBackColor = Color.Transparent;

            BackColor = Color.Transparent;
            ForeColor = colorTextoNormal;
            Font = new Font("Segoe UI Semibold", 10f, FontStyle.Bold);
            Size = new Size(220, 45);
            Cursor = Cursors.Hand;
            TextAlign = ContentAlignment.MiddleLeft;

            brushFondo = new SolidBrush(colorHover);
            whiteImageAttr = CreateWhiteImageAttributes();
        }

        #region Propiedades

        [Category("NicaCompare Custom")]
        public bool EsSeleccionado
        {
            get => esSeleccionado;
            set
            {
                if (esSeleccionado == value) return;
                esSeleccionado = value;
                Invalidate();
            }
        }

        [Category("NicaCompare Custom")]
        public bool AutoColorearIconoBlanco
        {
            get => autoColorearIconoBlanco;
            set { autoColorearIconoBlanco = value; Invalidate(); }
        }

        [Category("NicaCompare Custom")]
        public Color ColorHover
        {
            get => colorHover;
            set { colorHover = value; Invalidate(); }
        }

        [Category("NicaCompare Custom")]
        public Color ColorTextoNormal
        {
            get => colorTextoNormal;
            set { colorTextoNormal = value; Invalidate(); }
        }

        [Category("NicaCompare Custom")]
        public int BorderRadius
        {
            get => borderRadius;
            set
            {
                if (borderRadius == value) return;
                borderRadius = Math.Max(0, value);
                InvalidatePath();
                Invalidate();
            }
        }

        [Category("NicaCompare Custom")]
        public bool AutoEscalarImagen
        {
            get => autoEscalarImagen;
            set { autoEscalarImagen = value; Invalidate(); }
        }

        [Category("NicaCompare Custom")]
        public int PorcentajeEscalaImagen
        {
            get => porcentajeEscalaImagen;
            set
            {
                porcentajeEscalaImagen = Math.Max(10, Math.Min(90, value));
                Invalidate();
            }
        }

        [Category("NicaCompare Custom")]
        public int MargenImagenIzquierda
        {
            get => margenImagenIzquierda;
            set { margenImagenIzquierda = value; Invalidate(); }
        }

        #endregion

        #region Eventos

        protected override void OnMouseEnter(EventArgs e)
        {
            isHovered = true;
            Invalidate();
            base.OnMouseEnter(e);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            isHovered = false;
            isPressed = false;
            Invalidate();
            base.OnMouseLeave(e);
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isPressed = true;
                Invalidate();
            }
            base.OnMouseDown(e);
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            isPressed = false;
            Invalidate();
            base.OnMouseUp(e);
        }

        #endregion

        #region Pintado

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

            bool estaActivo = isHovered || isPressed || esSeleccionado;

            // Fondo azul solo cuando está activo
            if (estaActivo)
            {
                EnsurePath();
                brushFondo.Color = isPressed ? colorPressed : colorHover;
                g.FillPath(brushFondo, cachedPath);
            }

            Color colorTexto = estaActivo ? colorTextoHover : colorTextoNormal;

            int posXTexto = 15;
            int anchoTexto = Width - 30;

            // Icono
            if (Image != null)
            {
                float factor = porcentajeEscalaImagen / 100f;
                int imgH = Math.Max(1, (int)(Height * factor));
                float aspect = (float)Image.Width / Image.Height;
                int imgW = Math.Max(1, (int)(imgH * aspect));

                int imgX = margenImagenIzquierda;
                int imgY = (Height - imgH) / 2;
                Rectangle destRect = new Rectangle(imgX, imgY, imgW, imgH);

                if (estaActivo && autoColorearIconoBlanco)
                {
                    g.DrawImage(Image, destRect,
                        0, 0, Image.Width, Image.Height,
                        GraphicsUnit.Pixel, whiteImageAttr);
                }
                else
                {
                    g.DrawImage(Image, destRect);
                }

                posXTexto = imgX + imgW + 12;
                anchoTexto = Width - posXTexto - 10;
            }

            // Texto
            if (!string.IsNullOrEmpty(Text))
            {
                TextFormatFlags flags = GetTextFormatFlags(TextAlign);
                Rectangle textRect = new Rectangle(posXTexto, 0, Math.Max(1, anchoTexto), Height);
                TextRenderer.DrawText(g, Text, Font, textRect, colorTexto, flags);
            }
        }

        #endregion

        #region Caché

        private void EnsurePath()
        {
            if (cachedPath != null && cachedSize == ClientSize && cachedRadius == borderRadius)
                return;

            InvalidatePath();

            Rectangle rect = new Rectangle(0, 0, Width - 1, Height - 1);
            cachedPath = CreateRoundedPath(rect, borderRadius);
            cachedSize = ClientSize;
            cachedRadius = borderRadius;
        }

        private void InvalidatePath()
        {
            cachedPath?.Dispose();
            cachedPath = null;
        }

        private static GraphicsPath CreateRoundedPath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            if (radius <= 0)
            {
                path.AddRectangle(rect);
                return path;
            }

            int d = Math.Min(radius * 2, Math.Min(rect.Width, rect.Height));

            path.AddArc(rect.X, rect.Y, d, d, 180, 90);
            path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
            path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);
            path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90);
            path.CloseFigure();
            return path;
        }

        private static ImageAttributes CreateWhiteImageAttributes()
        {
            float[][] matrix =
            {
                new float[] {0, 0, 0, 0, 0},
                new float[] {0, 0, 0, 0, 0},
                new float[] {0, 0, 0, 0, 0},
                new float[] {0, 0, 0, 1, 0},
                new float[] {1, 1, 1, 0, 1}
            };

            var attr = new ImageAttributes();
            attr.SetColorMatrix(new ColorMatrix(matrix), ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
            return attr;
        }

        private static TextFormatFlags GetTextFormatFlags(ContentAlignment alignment)
        {
            TextFormatFlags flags = TextFormatFlags.WordBreak | TextFormatFlags.EndEllipsis;

            switch (alignment)
            {
                case ContentAlignment.TopLeft: flags |= TextFormatFlags.Top | TextFormatFlags.Left; break;
                case ContentAlignment.TopCenter: flags |= TextFormatFlags.Top | TextFormatFlags.HorizontalCenter; break;
                case ContentAlignment.TopRight: flags |= TextFormatFlags.Top | TextFormatFlags.Right; break;
                case ContentAlignment.MiddleLeft: flags |= TextFormatFlags.VerticalCenter | TextFormatFlags.Left; break;
                case ContentAlignment.MiddleCenter: flags |= TextFormatFlags.VerticalCenter | TextFormatFlags.HorizontalCenter; break;
                case ContentAlignment.MiddleRight: flags |= TextFormatFlags.VerticalCenter | TextFormatFlags.Right; break;
                case ContentAlignment.BottomLeft: flags |= TextFormatFlags.Bottom | TextFormatFlags.Left; break;
                case ContentAlignment.BottomCenter: flags |= TextFormatFlags.Bottom | TextFormatFlags.HorizontalCenter; break;
                case ContentAlignment.BottomRight: flags |= TextFormatFlags.Bottom | TextFormatFlags.Right; break;
            }
            return flags;
        }

        #endregion

        protected override void OnResize(EventArgs e)
        {
            InvalidatePath();
            base.OnResize(e);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                InvalidatePath();
                brushFondo?.Dispose();
                whiteImageAttr?.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}