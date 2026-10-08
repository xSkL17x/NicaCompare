using System.Collections.Generic;

namespace NicaCompare
{
    public static class ConfigScraper
    {
        public static readonly Dictionary<string, Dictionary<string, string>> Tiendas = new Dictionary<string, Dictionary<string, string>>
            {
                {
                    "La Curacao", new Dictionary<string, string>
                    {
                        { "Url", "https://www.lacuracaonline.com/nicaragua/search/" },
                        { "UserAgent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64)" },
                    }
                },
                {
                    "GCM", new Dictionary<string, string>
                    {
                        { "Url", "https://gcm.com.ni/?s=" },
                        { "UrlParametros", "&post_type=product" }, // Se remueve &type_aws=true para evitar conflictos de maquetación
                        { "UserAgent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64)" },
                        { "ExcluirNombres", "GCM|Search Results for|Somos Guardianes del Ahorro|Pago seguro con:" }
                    }
                },
                {
                    "SICSA", new Dictionary<string, string>
                    {
                        { "Url", "https://sicsa.com.ni/?s=" },
                        { "UrlParametros", "&post_type=product" },
                        { "UserAgent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64)" },
                        { "ExcluirNombres", "SICSA|Resultados|Categorías|Recommended Products|últimos productos|Filtro" }
                    }
                }
            };
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