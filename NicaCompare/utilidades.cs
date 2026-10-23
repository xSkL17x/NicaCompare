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



    public static class Utilidad
    {

        public static string AcortarTexto(string textoCompleto, int maxPalabras) // recortar texto evita muchas cosas
        {
            if (string.IsNullOrWhiteSpace(textoCompleto)) return "";

            var palabras = textoCompleto.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (palabras.Length <= maxPalabras)
            {
                return textoCompleto;
            }
            // Une solo las primeras N palabras y le agrega puntos suspensivos
            return string.Join(" ", palabras.Take(maxPalabras)) + "...";
        }


        /// Limpiar Precio, y convertir a numero
        public static decimal LimpiarPrecio(string precioTexto)
        {
            if (string.IsNullOrWhiteSpace(precioTexto) || precioTexto == "Sin precio") return decimal.MaxValue;

            // Normalizamos el texto general
            string textoProcesado = precioTexto.ToUpper()
                .Replace("U$", "$")
                .Replace("C$", "$")
                .Replace("\u00A0", "")
                .Replace("+IVA", "")
                .Replace("+ IVA", "")
                .Replace("IVA", "")
                .Trim();

            // Evitar más de 1 precio
            var fragmentos = textoProcesado.Split(new[] { '$' }, StringSplitOptions.RemoveEmptyEntries);
            List<decimal> montosEncontrados = new List<decimal>();

            foreach (var frag in fragmentos)
            {
                string limpio = frag.Replace(" ", "").Replace(",", "").Trim();

                // Convierte el texto limpio en un número para que no crashee y poder ordenar
                if (decimal.TryParse(limpio, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out decimal resultado))
                {
                    if (resultado > 0) { montosEncontrados.Add(resultado); }
                }
            }

            // Si encontró precios, devolvemos el menor (el precio de oferta real)
            if (montosEncontrados.Count > 0) { return montosEncontrados.Min(); }

            return decimal.MaxValue;
        }
    }

}