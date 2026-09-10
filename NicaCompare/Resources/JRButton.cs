using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace NicaCompare
{
    public class BotonRedondeado : Button
    {
        private int borderRadius = 20;

        public int BorderRadius
        {
            get => borderRadius;
            set { borderRadius = value; this.Invalidate(); }
        }

        public BotonRedondeado()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Size = new Size(220, 45);
            this.BackColor = Color.FromArgb(218, 103, 19);
            this.ForeColor = Color.White;
            this.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.Cursor = Cursors.Hand;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            Graphics g = pevent.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

            // 1. Dibujar el fondo del panel/formulario en las esquinas para eliminar el borde pixelado
            if (this.Parent != null)
            {
                using (SolidBrush parentBrush = new SolidBrush(this.Parent.BackColor))
                {
                    g.FillRectangle(parentBrush, this.ClientRectangle);
                }
            }

            Rectangle rect = new Rectangle(0, 0, this.Width - 1, this.Height - 1);

            using (GraphicsPath path = GetRoundedPath(rect, borderRadius))
            {
                // 2. Dibujar el fondo del botón redondeado
                using (SolidBrush brush = new SolidBrush(this.BackColor))
                {
                    g.FillPath(brush, path);
                }

                // 3. Dibujar línea suave de contorno
                using (Pen pen = new Pen(this.BackColor, 1.5f))
                {
                    g.DrawPath(pen, path);
                }

                this.Region = new Region(path);
            }

            // 4. Dibujar el texto perfectamente centrado encima del fondo
            Rectangle textRect = this.ClientRectangle;

            // Si le asignas un icono/imagen al botón
            if (this.Image != null)
            {
                int imgX = 15;
                int imgY = (this.Height - this.Image.Height) / 2;
                g.DrawImage(this.Image, imgX, imgY, this.Image.Width, this.Image.Height);

                // Mover el área de texto a la derecha de la imagen
                textRect = new Rectangle(imgX + this.Image.Width + 5, 0, this.Width - (imgX + this.Image.Width + 10), this.Height);
            }

            TextRenderer.DrawText(
                g,
                this.Text,
                this.Font,
                textRect,
                this.ForeColor,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter | TextFormatFlags.WordBreak
            );
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