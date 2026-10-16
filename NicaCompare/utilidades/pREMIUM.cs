using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace NicaCompare
{
    public enum NivelPlan
    {
        Basico,
        Premium,
        Elite
    }

    [DefaultEvent("ClickSeleccionar")]
    public class TarjetaPlan : UserControl
    {
        public event EventHandler ClickSeleccionar;

        private NivelPlan tipoPlan = NivelPlan.Basico;
        private Rectangle rectBoton;
        private bool hoverBoton;

        private static readonly Font FontTitulo = new Font("Segoe UI", 12F, FontStyle.Bold);
        private static readonly Font FontSub = new Font("Segoe UI", 8F);
        private static readonly Font FontPuntos = new Font("Segoe UI", 10.5F, FontStyle.Bold);
        private static readonly Font FontPrecio = new Font("Segoe UI", 16F, FontStyle.Bold);
        private static readonly Font FontBoton = new Font("Segoe UI", 9F, FontStyle.Bold);
        private static readonly Font FontItem = new Font("Segoe UI", 8.5F);
        private static readonly Font FontBadge = new Font("Segoe UI", 7F, FontStyle.Bold);

        private static readonly Color ColorAzul = Color.FromArgb(14, 116, 230);
        private static readonly Color ColorOscuro = Color.FromArgb(11, 37, 69);
        private static readonly Color ColorGrisBorde = Color.FromArgb(226, 232, 240);
        private static readonly Color ColorDorado = Color.FromArgb(254, 215, 102);
        private static readonly Color ColorTexto = Color.FromArgb(15, 23, 42);
        private static readonly Color ColorItem = Color.FromArgb(71, 85, 105);

        private static readonly string[] BeneficiosBasico =
        {
            "Descuentos exclusivos en tiendas",
            "Comparación de precios en tiempo real",
            "Historial de precios (últimos 7 días)",
            "Soporte por chat"
        };

        private static readonly string[] BeneficiosPremium =
        {
            "Todos los beneficios del plan Básico",
            "Descuentos VIP en todas las tiendas",
            "Alertas de bajada de precios",
            "Comparación avanzada",
            "Soporte prioritario 24/7"
        };

        private static readonly string[] BeneficiosElite =
        {
            "Todos los beneficios del plan Premium",
            "Descuentos VIP extendidos",
            "Compras con cashback (hasta 10%)",
            "Reportes personalizados de ahorro",
            "Acceso anticipado a funciones",
            "Soporte 24/7 + asesor personal"
        };

        [Category("NicaCompare Custom")]
        [DefaultValue(NivelPlan.Basico)]
        public NivelPlan TipoPlan
        {
            get => tipoPlan;
            set
            {
                if (tipoPlan == value)
                    return;

                tipoPlan = value;
                ActualizarRectanguloBoton();
                Invalidate();
            }
        }

        public TarjetaPlan()
        {
            SetStyle(
                ControlStyles.UserPaint |
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.ResizeRedraw |
                ControlStyles.SupportsTransparentBackColor,
                true
            );

            DoubleBuffered = true;
            BackColor = Color.Transparent;
            Size = new Size(270, 420);

            ActualizarRectanguloBoton();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            ActualizarRectanguloBoton();
        }

        private void ActualizarRectanguloBoton()
        {
            rectBoton = new Rectangle(
                18,
                142,
                Math.Max(1, Width - 36),
                36
            );
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);

            bool nuevoHover = rectBoton.Contains(e.Location);

            if (nuevoHover == hoverBoton)
                return;

            hoverBoton = nuevoHover;
            Cursor = hoverBoton ? Cursors.Hand : Cursors.Default;
            Invalidate(rectBoton);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);

            if (!hoverBoton)
                return;

            hoverBoton = false;
            Cursor = Cursors.Default;
            Invalidate(rectBoton);
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);

            if (e.Button == MouseButtons.Left &&
                rectBoton.Contains(e.Location))
            {
                ClickSeleccionar?.Invoke(this, EventArgs.Empty);
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;
            g.TextRenderingHint =
                System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

            int w = Width;
            int h = Height;

            if (w <= 5 || h <= 5)
                return;

            bool esPremium = tipoPlan == NivelPlan.Premium;
            bool esElite = tipoPlan == NivelPlan.Elite;

            Rectangle rectCard = new Rectangle(
                1,
                1,
                w - 3,
                h - 3
            );

            Color colorBorde =
                esPremium ? ColorAzul : ColorGrisBorde;

            float grosorBorde =
                esPremium ? 2F : 1F;

            using (GraphicsPath pathCard =
                   CrearPathRedondeado(rectCard, 12))
            {
                using (SolidBrush brush =
                       new SolidBrush(Color.White))
                {
                    g.FillPath(brush, pathCard);
                }

                if (esElite)
                {
                    Rectangle rectHeader = new Rectangle(
                        rectCard.X,
                        rectCard.Y,
                        rectCard.Width,
                        62
                    );

                    using (GraphicsPath pathHeader =
                           CrearPathSuperiorRedondeado(rectHeader, 12))
                    using (SolidBrush brushHeader =
                           new SolidBrush(ColorOscuro))
                    {
                        g.FillPath(brushHeader, pathHeader);
                    }
                }

                using (Pen pen =
                       new Pen(colorBorde, grosorBorde))
                {
                    g.DrawPath(pen, pathCard);
                }
            }

            if (esPremium)
            {
                DibujarBadge(
                    g,
                    "MÁS POPULAR",
                    ColorAzul,
                    Color.White,
                    w - 95,
                    0
                );
            }
            else if (esElite)
            {
                DibujarBadge(
                    g,
                    "MEJOR VALOR",
                    ColorDorado,
                    ColorOscuro,
                    w - 95,
                    8
                );
            }

            DibujarCorona(
                g,
                16,
                12,
                esElite ? ColorDorado : ColorAzul
            );

            string titulo;
            string subtitulo;
            string puntos;
            string precio;

            switch (tipoPlan)
            {
                case NivelPlan.Premium:
                    titulo = "Plan Premium";
                    subtitulo = "La mejor opción para más ventajas.";
                    puntos = "500 puntos";
                    precio = "C$ 99 / mes";
                    break;

                case NivelPlan.Elite:
                    titulo = "Plan Élite";
                    subtitulo = "Máximo ahorro y comodidad.";
                    puntos = "1,000 puntos";
                    precio = "C$ 149 / mes";
                    break;

                default:
                    titulo = "Plan Básico";
                    subtitulo = "Ideal para empezar a ahorrar.";
                    puntos = "100 puntos";
                    precio = "C$ 49 / mes";
                    break;
            }

            Brush brushTitulo =
                esElite ? Brushes.White : Brushes.Black;

            Brush brushSub =
                esElite ? Brushes.LightGray : Brushes.Gray;

            g.DrawString(
                titulo,
                FontTitulo,
                brushTitulo,
                42,
                10
            );

            g.DrawString(
                subtitulo,
                FontSub,
                brushSub,
                18,
                36
            );

            DibujarEstrellaPuntos(g, 18, 75);

            using (SolidBrush brush =
                   new SolidBrush(ColorTexto))
            {
                g.DrawString(
                    puntos,
                    FontPuntos,
                    brush,
                    42,
                    73
                );
            }

            using (SolidBrush brush =
                   new SolidBrush(ColorOscuro))
            {
                g.DrawString(
                    precio,
                    FontPrecio,
                    brush,
                    18,
                    102
                );
            }

            DibujarBoton(
                g,
                rectBoton,
                hoverBoton
            );

            string[] beneficios =
                ObtenerBeneficios();

            int posY = 194;

            using (SolidBrush brush =
                   new SolidBrush(ColorItem))
            {
                foreach (string item in beneficios)
                {
                    DibujarCheck(
                        g,
                        18,
                        posY + 2
                    );

                    g.DrawString(
                        item,
                        FontItem,
                        brush,
                        new RectangleF(
                            38,
                            posY,
                            w - 45,
                            28
                        )
                    );

                    posY += 26;
                }
            }
        }

        private void DibujarBoton(
            Graphics g,
            Rectangle rect,
            bool hover)
        {
            Color fondo =
                hover ? ColorAzul : Color.White;

            Color texto =
                hover ? Color.White : ColorAzul;

            using (GraphicsPath path =
                   CrearPathRedondeado(rect, 18))
            {
                using (SolidBrush brush =
                       new SolidBrush(fondo))
                {
                    g.FillPath(brush, path);
                }

                using (Pen pen =
                       new Pen(ColorAzul, 1.5F))
                {
                    g.DrawPath(pen, path);
                }
            }

            TextRenderer.DrawText(
                g,
                "Seleccionar plan",
                FontBoton,
                rect,
                texto,
                TextFormatFlags.HorizontalCenter |
                TextFormatFlags.VerticalCenter |
                TextFormatFlags.NoPadding
            );
        }

        private string[] ObtenerBeneficios()
        {
            switch (tipoPlan)
            {
                case NivelPlan.Premium:
                    return BeneficiosPremium;

                case NivelPlan.Elite:
                    return BeneficiosElite;

                default:
                    return BeneficiosBasico;
            }
        }

        private void DibujarCorona(
            Graphics g,
            float x,
            float y,
            Color color)
        {
            using (Pen pen =
                   new Pen(color, 1.8F)
                   {
                       LineJoin = LineJoin.Round
                   })
            using (SolidBrush brush =
                   new SolidBrush(color))
            {
                PointF[] puntos =
                {
                    new PointF(x + 1, y + 5),
                    new PointF(x + 4, y + 15),
                    new PointF(x + 16, y + 15),
                    new PointF(x + 19, y + 5),
                    new PointF(x + 14, y + 9),
                    new PointF(x + 10, y + 2),
                    new PointF(x + 6, y + 9)
                };

                g.DrawPolygon(pen, puntos);

                g.FillEllipse(
                    brush,
                    x,
                    y + 2,
                    3F,
                    3F
                );

                g.FillEllipse(
                    brush,
                    x + 8.5F,
                    y - 1,
                    3F,
                    3F
                );

                g.FillEllipse(
                    brush,
                    x + 17F,
                    y + 2,
                    3F,
                    3F
                );
            }
        }

        private void DibujarEstrellaPuntos(
            Graphics g,
            float x,
            float y)
        {
            using (SolidBrush brushBg =
                   new SolidBrush(
                       Color.FromArgb(251, 191, 36)))
            using (SolidBrush brushStar =
                   new SolidBrush(Color.White))
            {
                g.FillEllipse(
                    brushBg,
                    x,
                    y,
                    18,
                    18
                );

                PointF[] puntos =
                {
                    new PointF(x + 9, y + 3),
                    new PointF(x + 10.8F, y + 6.8F),
                    new PointF(x + 15, y + 7.4F),
                    new PointF(x + 12, y + 10.3F),
                    new PointF(x + 12.8F, y + 14.3F),
                    new PointF(x + 9, y + 12.2F),
                    new PointF(x + 5.2F, y + 14.3F),
                    new PointF(x + 6, y + 10.3F),
                    new PointF(x + 3, y + 7.4F),
                    new PointF(x + 7.2F, y + 6.8F)
                };

                g.FillPolygon(
                    brushStar,
                    puntos
                );
            }
        }

        private void DibujarCheck(
            Graphics g,
            float x,
            float y)
        {
            using (SolidBrush brushBg =
                   new SolidBrush(ColorAzul))
            using (Pen pen =
                   new Pen(
                       Color.White,
                       1.5F)
                   {
                       StartCap = LineCap.Round,
                       EndCap = LineCap.Round
                   })
            {
                g.FillEllipse(
                    brushBg,
                    x,
                    y,
                    14,
                    14
                );

                g.DrawLine(
                    pen,
                    x + 3.5F,
                    y + 7F,
                    x + 6F,
                    y + 9.5F
                );

                g.DrawLine(
                    pen,
                    x + 6F,
                    y + 9.5F,
                    x + 10.5F,
                    y + 4.5F
                );
            }
        }

        private void DibujarBadge(
            Graphics g,
            string texto,
            Color bg,
            Color fg,
            int x,
            int y)
        {
            Rectangle rect =
                new Rectangle(
                    x,
                    y,
                    85,
                    18
                );

            using (GraphicsPath path =
                   CrearPathRedondeado(rect, 9))
            using (SolidBrush brush =
                   new SolidBrush(bg))
            {
                g.FillPath(
                    brush,
                    path
                );
            }

            TextRenderer.DrawText(
                g,
                texto,
                FontBadge,
                rect,
                fg,
                TextFormatFlags.HorizontalCenter |
                TextFormatFlags.VerticalCenter |
                TextFormatFlags.NoPadding
            );
        }

        private static GraphicsPath CrearPathRedondeado(
            Rectangle rect,
            int radius)
        {
            GraphicsPath path =
                new GraphicsPath();

            int d = radius * 2;

            path.StartFigure();

            path.AddArc(
                rect.X,
                rect.Y,
                d,
                d,
                180,
                90
            );

            path.AddArc(
                rect.Right - d,
                rect.Y,
                d,
                d,
                270,
                90
            );

            path.AddArc(
                rect.Right - d,
                rect.Bottom - d,
                d,
                d,
                0,
                90
            );

            path.AddArc(
                rect.X,
                rect.Bottom - d,
                d,
                d,
                90,
                90
            );

            path.CloseFigure();

            return path;
        }

        private static GraphicsPath CrearPathSuperiorRedondeado(
            Rectangle rect,
            int radius)
        {
            GraphicsPath path =
                new GraphicsPath();

            int d = radius * 2;

            path.StartFigure();

            path.AddArc(
                rect.X,
                rect.Y,
                d,
                d,
                180,
                90
            );

            path.AddArc(
                rect.Right - d,
                rect.Y,
                d,
                d,
                270,
                90
            );

            path.AddLine(
                rect.Right,
                rect.Bottom,
                rect.X,
                rect.Bottom
            );

            path.CloseFigure();

            return path;
        }
    }
}
