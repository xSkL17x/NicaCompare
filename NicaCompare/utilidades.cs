using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace NicaCompare
{
    public static class Imgagenes
    {
        public static Image Obtener(string nomImg, string imgPorDefecto = "LOGO_22")
        {
            string nombreLimpio = !string.IsNullOrEmpty(nomImg) ? nomImg.Replace("Properties.Resources.", "") : "";
            var imgObjeto = !string.IsNullOrEmpty(nombreLimpio) ? Properties.Resources.ResourceManager.GetObject(nombreLimpio) : null;

            if (imgObjeto != null) { return (Image)imgObjeto; }
            
            string defectoLimpias = !string.IsNullOrEmpty(imgPorDefecto) ? imgPorDefecto.Replace("Properties.Resources.", "") : "LOGO_22";
            var imgDefectoObjeto = Properties.Resources.ResourceManager.GetObject(defectoLimpias);

            return imgDefectoObjeto != null ? (Image)imgDefectoObjeto : Properties.Resources.LOGO_22;
        }

        public static void Guardar(string rutaOrigen, string nombreimg)
        {
            string carpetaProyecto = Path.GetFullPath(Path.Combine(Application.StartupPath, @"..\..\Resources"));
            string rutaDestino = Path.Combine(carpetaProyecto, nombreimg  + ".png");

            using (Image original = Image.FromFile(rutaOrigen))
            {
                using (Bitmap b = new Bitmap(512, 512))
                {
                    using (Graphics g = Graphics.FromImage(b))
                    {
                        g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                        g.SmoothingMode = SmoothingMode.HighQuality;
                        g.PixelOffsetMode = PixelOffsetMode.HighQuality;
                        g.DrawImage(original, 0, 0, 512, 512);
                    }
                    b.Save(rutaDestino, ImageFormat.Png);
                }
            }
        }
    }

    public static class Pantallas
    {
        public static void cambiar<Formulario>(Form formularioActual) where Formulario : Form, new()
        {
            Formulario nuevaPantalla = new Formulario();
            nuevaPantalla.FormClosed += (s, args) => formularioActual.Close();
            nuevaPantalla.Show();
            formularioActual.Hide();
        }
    }
}