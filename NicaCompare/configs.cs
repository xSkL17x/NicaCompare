using System.Collections.Generic;

namespace NicaCompare
{
    public static class ConfigScraper
    {
        public static readonly Dictionary<string, Dictionary<string, string>> Tiendas = new Dictionary<string, Dictionary<string, string>>
        {
            {
                "el GallomasGallo", new Dictionary<string, string>
                {
                    { "img", "el_gallo_mas_gallo_nuevo" },
                    { "Url", "https://wlt832ea3j-dsn.algolia.net/1/indexes/monge_upgrade_prod_elgallo_ni_products/query" },
                    { "Tipo", "Algolia" },
                    { "AlgoliaAppId", "WLT832EA3J" },
                    { "AlgoliaApiKey", "YTYwZjI3ODFjOTI3YWQ0MjJmYzQ3ZjBiNmY1Y2FiYjRhZjNiMmM3NmMxYTMyNDUwOGUxYjhkMWFhMzFlOGExNnRhZ0ZpbHRlcnM9" },
                    { "Activo", "SI" },
                    { "UserAgent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64)" },
                    { "ExcluirNombres", "Menú|Menu" },
                    { "XPathContenedor", "//li[contains(@class, 'ais-Hits-item')]" },
                    { "XPathTitulo", ".//*[contains(@class, 'result-title')]" },
                    { "XPathPrecio", ".//*[contains(@class, 'price')]" }
                }
            },
            {
                "la Curaca", new Dictionary<string, string>
                {
                    //{ "img", "el_gallo_mas_gallo_nuevo" },
                    { "Url", "https://wlt832ea3j-dsn.algolia.net/1/indexes/monge_upgrade_prod_elgallo_ni_products/query" },
                    { "Tipo", "Algolia" },
                    { "AlgoliaAppId", "WLT832EA3J" },
                    { "AlgoliaApiKey", "YTYwZjI3ODFjOTI3YWQ0MjJmYzQ3ZjBiNmY1Y2FiYjRhZjNiMmM3NmMxYTMyNDUwOGUxYjhkMWFhMzFlOGExNnRhZ0ZpbHRlcnM9" },
                    { "Activo", "SI" },
                    { "UserAgent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64)" },
                    { "ExcluirNombres", "Menú|Menu" },
                    { "XPathContenedor", "//li[contains(@class, 'ais-Hits-item')]" },
                    { "XPathTitulo", ".//*[contains(@class, 'result-title')]" },
                    { "XPathPrecio", ".//*[contains(@class, 'price')]" }
                }
            },


            {
                "GCM", new Dictionary<string, string>
                {
                    { "img", "Properties.Resources.GCM" },
                    { "Url", "https://gcm.com.ni/?s=" },
                    { "UrlParametros", "&post_type=product" },
                    { "Activo", "SI" },
                    { "UserAgent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64)" },
                    { "ExcluirNombres", "GCM|Search Results for|Somos Guardianes del Ahorro|Pago seguro con:" },
                    { "XPathContenedor", "//li[contains(@class, 'type-product')]" },
                    { "XPathTitulo", ".//div[contains(@class, 'product-content')]//h2//a | .//h2//a | .//*[contains(@class, 'woocommerce-loop-product__title')] | .//h2 | .//h3" },
                    { "XPathPrecio", ".//div[contains(@class, 'mf-product-price-box')]//span[contains(@class, 'woocommerce-Price-amount')] | .//span[contains(@class, 'price')]//bdi | .//bdi | .//*[contains(@class, 'price')]" },
                    { "XPathImagen", ".//img[contains(@class, 'attachment-woocommerce_thumbnail')]" }
                }
            },

            {
                "SICSA", new Dictionary<string, string>
                {
                    { "img", "Properties.Resources.Sicsa_logo" },
                    { "Url", "https://sicsa.com.ni/?s=" },
                    { "UrlParametros", "&post_type=product" },
                    { "Activo", "SI" },
                    { "UserAgent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64)" },
                    { "ExcluirNombres", "SICSA|Resultados|Categorías|Recommended Products|últimos productos|Filtro|Producto Prueba|Productos relacionados" },
                    { "XPathContenedor", "//li[contains(@class, 'type-product')] | //*[contains(@class, 'product') and not(contains(@class, 'category'))]" },
                    { "XPathTitulo", ".//*[contains(@class, 'woocommerce-loop-product__title')] | .//h2 | .//h3" },
                    { "XPathPrecio", ".//span[contains(@class, 'price')]//bdi | .//span[contains(@class, 'woocommerce-Price-amount')] | .//ins//bdi | .//bdi | .//*[contains(@class, 'price')]" },
                    { "XPathImagen", ".//img[contains(@class, 'attachment-woocommerce_thumbnail')]" }
                }
            }
        };

    }



}