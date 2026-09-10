using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace NicaCompare
{
    [DefaultEvent("CheckedChanged")]
    public class TarjetaTienda : Control
    {
        private Image? imagen;
        private bool seleccionado = false;
        private bool mostrarSeparador = true;
        private bool mostrarBorde = false; // Por defecto SIN borde
        private int margenImagen = 8; // Relleno interno de la imagen
        private Size tamañoImagen = Size.Empty; // Tamaño personalizado opcional (Ancho, Alto)
        private bool isHovered = false;

        private Color colorFondo = Color.White;
        private Color colorBorde = Color.FromArgb(220, 224, 230);
        private Color colorCheck = Color.FromArgb(13, 110, 253); // Azul primario
        private Color colorSeparador = Color.FromArgb(235, 238, 242);

        public event EventHandler? CheckedChanged;

        // --- PROPIEDADES VISIBLES EN EL DISEÑADOR ---

        [Category("NicaCompare Custom"), Description("Imagen o Logo de la tienda")]
        public Image? Imagen
        {
            get => imagen;
            set { imagen = value; this.Invalidate(); }
        }

        [Category("NicaCompare Custom"), Description("Margen/Relleno alrededor de la imagen en píxeles. Disminúyelo para hacer la imagen más grande.")]
        public int MargenImagen
        {
            get => margenImagen;
            set { margenImagen = Math.Max(0, value); this.Invalidate(); }
        }

        [Category("NicaCompare Custom"), Description("Tamaño exacto de la imagen (Ancho, Alto). Deja en (0, 0) para ajuste automático según el margen.")]
        public Size TamañoImagen
        {
            get => tamañoImagen;
            set { tamañoImagen = value; this.Invalidate(); }
        }

        [Category("NicaCompare Custom"), Description("Indica si la tarjeta está seleccionada")]
        public bool Seleccionado
        {
            get => seleccionado;
            set
            {
                if (seleccionado != value)
                {
                    seleccionado = value;
                    CheckedChanged?.Invoke(this, EventArgs.Empty);
                    this.Invalidate();
                }
            }
        }

        [Category("NicaCompare Custom"), Description("Muestra u oculta el borde alrededor del botón")]
        public bool MostrarBorde
        {
            get => mostrarBorde;
            set { mostrarBorde = value; this.Invalidate(); }
        }

        [Category("NicaCompare Custom"), Description("Color del borde cuando MostrarBorde está activo")]
        public Color ColorBorde
        {
            get => colorBorde;
            set { colorBorde = value; this.Invalidate(); }
        }

        [Category("NicaCompare Custom"), Description("Muestra una línea divisoria vertical a la derecha")]
        public bool MostrarSeparador
        {
            get => mostrarSeparador;
            set { mostrarSeparador = value; this.Invalidate(); }
        }

        [Category("NicaCompare Custom"), Description("Color del círculo de selección")]
        public Color ColorCheck
        {
            get => colorCheck;
            set { colorCheck = value; this.Invalidate(); }
        }

        public TarjetaTienda()
        {
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

            this.BackColor = Color.Transparent;
            this.Size = new Size(140, 60);
            this.MinimumSize = new Size(40, 30);
            this.Cursor = Cursors.Hand;
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            isHovered = true;
            this.Invalidate();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            isHovered = false;
            this.Invalidate();
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            Seleccionado = !Seleccionado;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (this.Width <= 10 || this.Height <= 10) return;

            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;

            // 1. Fondo limpio sin bordes molestos
            Rectangle rectCard = new Rectangle(0, 0, this.Width, this.Height);
            using (SolidBrush brushFondo = new SolidBrush(isHovered ? Color.FromArgb(245, 248, 255) : colorFondo))
            {
                g.FillRectangle(brushFondo, rectCard);
            }

            int anchoUtil = mostrarSeparador ? this.Width - 2 : this.Width;

            // 2. Dibujar Imagen / Logo
            Image? imgParaDibujar = imagen ?? this.BackgroundImage;

            if (imgParaDibujar != null)
            {
                Rectangle rectDestino;

                // Si se definió un tamaño manual explícito en TamañoImagen
                if (tamañoImagen.Width > 0 && tamañoImagen.Height > 0)
                {
                    int posX = (anchoUtil - tamañoImagen.Width) / 2;
                    int posY = (this.Height - tamañoImagen.Height) / 2;
                    rectDestino = new Rectangle(posX, posY, tamañoImagen.Width, tamañoImagen.Height);
                }
                else
                {
                    // Escalado dinámico respetando el MargenImagen
                    Rectangle rectAreaDisponible = new Rectangle(
                        margenImagen,
                        margenImagen,
                        Math.Max(1, anchoUtil - (margenImagen * 2)),
                        Math.Max(1, this.Height - (margenImagen * 2))
                    );
                    rectDestino = CalcularEscaladoProporcional(imgParaDibujar.Size, rectAreaDisponible);
                }

                g.DrawImage(imgParaDibujar, rectDestino);
            }

            // 3. Dibujar Checkmark Azul (Si está seleccionado)
            if (seleccionado)
            {
                int badgeSize = 16;
                int badgeX = anchoUtil - badgeSize - 6;
                int badgeY = 6;

                Rectangle rectBadge = new Rectangle(badgeX, badgeY, badgeSize, badgeSize);

                using (SolidBrush brushBadge = new SolidBrush(colorCheck))
                {
                    g.FillEllipse(brushBadge, rectBadge);
                }

                using (Pen penCheck = new Pen(Color.White, 1.8f))
                {
                    penCheck.StartCap = LineCap.Round;
                    penCheck.EndCap = LineCap.Round;

                    Point[] puntosCheck = {
                        new Point(badgeX + 4, badgeY + 8),
                        new Point(badgeX + 7, badgeY + 11),
                        new Point(badgeX + 12, badgeY + 5)
                    };
                    g.DrawLines(penCheck, puntosCheck);
                }
            }

            // 4. Borde opcional
            if (mostrarBorde)
            {
                using (Pen penBorde = new Pen(colorBorde, 1.0f))
                {
                    g.DrawRectangle(penBorde, 0, 0, this.Width - 1, this.Height - 1);
                }
            }

            // 5. Línea divisoria vertical a la derecha
            if (mostrarSeparador)
            {
                using (Pen penSeparador = new Pen(colorSeparador, 1.0f))
                {
                    int xSeparador = this.Width - 1;
                    int marginY = 8;
                    g.DrawLine(penSeparador, xSeparador, marginY, xSeparador, this.Height - marginY);
                }
            }
        }

        private Rectangle CalcularEscaladoProporcional(Size imgSize, Rectangle boundary)
        {
            if (imgSize.Width <= 0 || imgSize.Height <= 0 || boundary.Width <= 0 || boundary.Height <= 0)
                return boundary;

            float ratioX = (float)boundary.Width / imgSize.Width;
            float ratioY = (float)boundary.Height / imgSize.Height;
            float ratio = Math.Min(ratioX, ratioY);

            int newWidth = (int)(imgSize.Width * ratio);
            int newHeight = (int)(imgSize.Height * ratio);

            int posX = boundary.X + (boundary.Width - newWidth) / 2;
            int posY = boundary.Y + (boundary.Height - newHeight) / 2;

            return new Rectangle(posX, posY, newWidth, newHeight);
        }
    }
}