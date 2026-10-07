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
                    { "UserAgent", "Mozilla/5.0" }
                }
            },
            {
                "GCM", new Dictionary<string, string>
                {
                    { "Url", "https://gcm.com.ni/?s=" },
                    { "UrlParametros", "&post_type=product&type_aws=true" },
                    { "UserAgent", "Mozilla/5.0" },
                    { "ExcluirNombres", "GCM|Search Results for" }
                }
            },
            {
                "SICSA", new Dictionary<string, string>
                {
                    { "Url", "https://sicsa.com.ni/?s=" },
                    { "UserAgent", "Mozilla/5.0" },
                    { "ExcluirNombres", "SICSA|Resultados" }
                }
            }
        };
    }
}