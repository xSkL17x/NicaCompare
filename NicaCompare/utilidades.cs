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
            // limpiamos el nombre
            string nombreLimpio = !string.IsNullOrEmpty(nomImg) ? nomImg.Replace("Properties.Resources.", "") : "";

            // si no esta en resources buscamos en la carpeta fisica
            if (!string.IsNullOrEmpty(nombreLimpio))
            {
                string rutaArchivo = Path.Combine(Path.GetFullPath(Path.Combine(Application.StartupPath, @"..\..\Resources")), nombreLimpio + ".png");
                if (File.Exists(rutaArchivo)) { using (var ms = new MemoryStream(File.ReadAllBytes(rutaArchivo))) { return Image.FromStream(ms); } }
            }

            // buscamos en resources normales
            var imgObjeto = !string.IsNullOrEmpty(nombreLimpio) ? Properties.Resources.ResourceManager.GetObject(nombreLimpio) : null;
            if (imgObjeto != null) { return (Image)imgObjeto; }

            // limpiamos la imagen por defecto
            string defectoLimpias = !string.IsNullOrEmpty(imgPorDefecto) ? imgPorDefecto.Replace("Properties.Resources.", "") : "LOGO_22";
            var imgDefectoObjeto = Properties.Resources.ResourceManager.GetObject(defectoLimpias);

            // si todo falla devolvemos el logo por defecto
            return imgDefectoObjeto != null ? (Image)imgDefectoObjeto : Properties.Resources.LOGO_22;
        }

        public static void Guardar(string rutaOrigen, string nombreimg)
        {
            // armamos la ruta hacia la carpeta Resources del proyecto
            string carpetaProyecto = Path.GetFullPath(Path.Combine(Application.StartupPath, @"..\..\Resources"));

            // aseguramos que la carpeta exista por si acaso
            if (!Directory.Exists(carpetaProyecto)) { Directory.CreateDirectory(carpetaProyecto); }

            string rutaDestino = Path.Combine(carpetaProyecto, nombreimg + ".png");

            // cargamos la imagen original y la redimensionamos a 512x512 con alta calidad
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

                    // guardamos la imagen procesada en formato png
                    b.Save(rutaDestino, ImageFormat.Png);
                }
            }
        }

        public static void Eliminar(string nombreImg)
        {
            // limpiamos el nombre por si trae prefijo
            string nombreLimpio = !string.IsNullOrEmpty(nombreImg) ? nombreImg.Replace("Properties.Resources.", "") : "";
            if (string.IsNullOrEmpty(nombreLimpio)) { return; }

            // armamos la ruta hacia la carpeta Resources del proyecto
            string carpetaProyecto = Path.GetFullPath(Path.Combine(Application.StartupPath, @"..\..\Resources"));
            string rutaArchivo = Path.Combine(carpetaProyecto, nombreLimpio + ".png");

            // eliminamos el archivo fisico si existe en la carpeta
            if (File.Exists(rutaArchivo))
            {
                try { File.Delete(rutaArchivo); } catch { }
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