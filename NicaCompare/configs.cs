using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

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
                "La Curacao Nicaragua", new Dictionary<string, string>
                {
                    { "img", "curacao_logo" },
                    { "Url", "https://ac.cnstrc.com/search/" },
                    { "Tipo", "Constructor" },
                    { "ApiKey", "key_7b10095b8a334dc8984d118d0266aa" },
                    { "Activo", "SI" },
                    { "UserAgent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64)" },
                    { "ExcluirNombres", "Menú|Menu" },
                    { "XPathContenedor", "//li[contains(@class, 'product-item')]" },
                    { "XPathTitulo", ".//*[contains(@class, 'product-item-link')]" },
                    { "XPathPrecio", ".//*[contains(@class, 'price')]" }
                }
            },
            {
                "GCM", new Dictionary<string, string>
                {
                    { "img", "GCM" },
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
                    { "img", "Sicsa_logo" },
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


        public static async Task<(string, List<ProductoResult>)> ScrapearTiendaAsync(HttpClient client, string textoBuscado, KeyValuePair<string, Dictionary<string, string>> tienda)
        {
            if (tienda.Value.ContainsKey("Tipo"))
            {
                if (tienda.Value["Tipo"] == "Algolia"){return await scraping_Algolia(client, textoBuscado, tienda);}

                else if (tienda.Value["Tipo"] == "Constructor"){ return await scraping_Constructor(client, textoBuscado, tienda);}
            }

            return await scraping_v1(client, textoBuscado, tienda);
        }



        public static async Task<(string, List<ProductoResult>)> scraping_v1(HttpClient client, string textoBuscado, KeyValuePair<string, Dictionary<string, string>> tienda)
        {
            List<ProductoResult> productosEncontrados = new List<ProductoResult>();
            try
            {
                string textoCodificado = Uri.EscapeDataString(textoBuscado);
                string urlBusqueda = tienda.Value["Url"] + textoCodificado + (tienda.Value.ContainsKey("UrlParametros") ? tienda.Value["UrlParametros"] : "");
                using (var request = new HttpRequestMessage(HttpMethod.Get, urlBusqueda))
                {
                    if (tienda.Value.ContainsKey("UserAgent")) { request.Headers.Add("User-Agent", tienda.Value["UserAgent"]); }

                    var response = await client.SendAsync(request);
                    if (response.IsSuccessStatusCode)
                    {
                        string html = await response.Content.ReadAsStringAsync();
                        HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
                        doc.LoadHtml(html);

                        string xpathContenedor = tienda.Value.ContainsKey("XPathContenedor") ? tienda.Value["XPathContenedor"] : "//*[contains(@class, 'product') and not(contains(@class, 'category'))]";
                        var nodosProductos = doc.DocumentNode.SelectNodes(xpathContenedor);

                        if (nodosProductos != null)
                        {
                            int count = 0;
                            string[] palabrasExcluidas = tienda.Value.ContainsKey("ExcluirNombres") ? tienda.Value["ExcluirNombres"].Split('|') : new string[0];
                            string[] terminosOmitir = { "Añadir al carrito", "Agregar a Lista de deseos", "Leer más" };
                            string xpathTitulo = tienda.Value.ContainsKey("XPathTitulo") ? tienda.Value["XPathTitulo"] : ".//*[contains(@class, 'title') or contains(@class, 'name') or name()='h2' or name()='h3']";
                            string xpathPrecio = tienda.Value.ContainsKey("XPathPrecio") ? tienda.Value["XPathPrecio"] : ".//ins//bdi | .//bdi | .//*[contains(@class, 'electro-price')] | .//*[contains(@class, 'price')]";

                            foreach (var nodo in nodosProductos)
                            {
                                if (count >= 1000) break;
                                var nodoTitulo = nodo.SelectSingleNode(xpathTitulo);
                                var nodoPrecio = nodo.SelectSingleNode(xpathPrecio);
                                string nombre = nodoTitulo != null ? System.Net.WebUtility.HtmlDecode(nodoTitulo.InnerText.Trim()).Replace("\n", " ").Replace("\r", "") : "";
                                string precio = nodoPrecio != null ? System.Net.WebUtility.HtmlDecode(nodoPrecio.InnerText.Trim()).Replace("\n", " ").Replace("\r", "") : "Sin precio";

                                foreach (var term in terminosOmitir) { precio = precio.Replace(term, ""); }
                                precio = precio.Trim();

                                bool esValido = !string.IsNullOrEmpty(nombre);
                                foreach (var palabra in palabrasExcluidas) { if (nombre.Contains(palabra, StringComparison.OrdinalIgnoreCase)) { esValido = false; break; } }
                                if (esValido)
                                {
                                    productosEncontrados.Add(new ProductoResult { Nombre = nombre, PrecioTexto = precio, PrecioMonto = ParsearPrecio(precio), TiendaKey = tienda.Key });
                                    count++;
                                }
                            }
                        }
                    }
                }
            }
            catch { }
            return (tienda.Key, productosEncontrados);
        }

        public static async Task<(string, List<ProductoResult>)> scraping_Algolia(HttpClient client, string textoBuscado, KeyValuePair<string, Dictionary<string, string>> tienda)
        {
            List<ProductoResult> productosEncontrados = new List<ProductoResult>();
            try
            {
                string urlAlgolia = tienda.Value["Url"];
                var payload = new { query = textoBuscado, hitsPerPage = 40 };
                string jsonBody = JsonSerializer.Serialize(payload);
                using (var req = new HttpRequestMessage(HttpMethod.Post, urlAlgolia))
                {
                    req.Headers.Add("X-Algolia-Application-Id", tienda.Value["AlgoliaAppId"]);
                    req.Headers.Add("X-Algolia-API-Key", tienda.Value["AlgoliaApiKey"]);
                    req.Content = new StringContent(jsonBody, Encoding.UTF8, "application/json");

                    var resp = await client.SendAsync(req);
                    if (resp.IsSuccessStatusCode)
                    {
                        string jsonRes = await resp.Content.ReadAsStringAsync();
                        using (var doc = JsonDocument.Parse(jsonRes))
                        {
                            if (doc.RootElement.TryGetProperty("hits", out var hits) && hits.ValueKind == JsonValueKind.Array)
                            {
                                foreach (var hit in hits.EnumerateArray())
                                {
                                    string nombre = hit.TryGetProperty("name", out var nProp) ? nProp.GetString() ?? "" : "";
                                    string precioTexto = "Sin precio";
                                    decimal precioMonto = decimal.MaxValue;

                                    if (hit.TryGetProperty("price", out var pObj) && pObj.ValueKind == JsonValueKind.Object)
                                    {
                                        if (pObj.TryGetProperty("NIO", out var nio) && nio.ValueKind == JsonValueKind.Object)
                                        {
                                            if (nio.TryGetProperty("default_formated", out var df)) { precioTexto = df.GetString() ?? "Sin precio"; }
                                            if (nio.TryGetProperty("default", out var dv) && dv.TryGetDecimal(out var dec)) { precioMonto = dec; }
                                        }
                                    }

                                    if (!string.IsNullOrEmpty(nombre))
                                    {
                                        if (precioMonto == decimal.MaxValue) precioMonto = ParsearPrecio(precioTexto);
                                        productosEncontrados.Add(new ProductoResult { Nombre = nombre, PrecioTexto = precioTexto, PrecioMonto = precioMonto, TiendaKey = tienda.Key });
                                    }
                                }
                            }
                        }
                    }
                }
            } catch { } return (tienda.Key, productosEncontrados);
        }

        
        public static async Task<(string, List<ProductoResult>)> scraping_Constructor(HttpClient client, string textoBuscado, KeyValuePair<string, Dictionary<string, string>> tienda)
        {
            List<ProductoResult> productosEncontrados = new List<ProductoResult>();
            try
            {
                string textoCodificado = Uri.EscapeDataString(textoBuscado);
                string urlBusqueda = tienda.Value["Url"] + textoCodificado + "?key=" + tienda.Value["ApiKey"] + "&num_results_per_page=40";
                using (var req = new HttpRequestMessage(HttpMethod.Get, urlBusqueda))
                {
                    if (tienda.Value.ContainsKey("UserAgent")) { req.Headers.Add("User-Agent", tienda.Value["UserAgent"]); }

                    var resp = await client.SendAsync(req);
                    if (resp.IsSuccessStatusCode)
                    {
                        string jsonRes = await resp.Content.ReadAsStringAsync();
                        using (var doc = JsonDocument.Parse(jsonRes))
                        {
                            if (doc.RootElement.TryGetProperty("response", out var respObj) &&
                                respObj.TryGetProperty("results", out var results) &&
                                results.ValueKind == JsonValueKind.Array)
                            {
                                foreach (var item in results.EnumerateArray())
                                {
                                    if (item.TryGetProperty("data", out var dataObj) && dataObj.ValueKind == JsonValueKind.Object)
                                    {
                                        string nombre = dataObj.TryGetProperty("name", out var nProp) ? nProp.GetString() ?? "" : "";
                                        string precioTexto = "Sin precio";
                                        decimal precioMonto = decimal.MaxValue;

                                        if (dataObj.TryGetProperty("price", out var pProp))
                                        {
                                            if (pProp.ValueKind == JsonValueKind.String) { precioTexto = pProp.GetString() ?? "Sin precio"; }
                                            else if (pProp.ValueKind == JsonValueKind.Number) { precioMonto = pProp.GetDecimal(); precioTexto = "C$ " + precioMonto.ToString("N2"); }
                                        }

                                        if (!string.IsNullOrEmpty(nombre))
                                        {
                                            if (precioMonto == decimal.MaxValue) precioMonto = ParsearPrecio(precioTexto);
                                            productosEncontrados.Add(new ProductoResult { Nombre = nombre, PrecioTexto = precioTexto, PrecioMonto = precioMonto, TiendaKey = tienda.Key });
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            } catch { } return (tienda.Key, productosEncontrados);
        }



        public static decimal ParsearPrecio(string precioTexto)
        {
            if (string.IsNullOrWhiteSpace(precioTexto) || precioTexto == "Sin precio") return decimal.MaxValue;
            string limpio = precioTexto.ToUpper()
                .Replace("C$", "")
                .Replace("U$", "")
                .Replace("$", "")
                .Replace(" ", "")
                .Replace("\u00A0", "")
                .Replace(",", "")
                .Replace("+IVA", "")
                .Replace("IVA", "")
                .Trim();
            if (decimal.TryParse(limpio, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out decimal resultado)) { return resultado; }
            return decimal.MaxValue;
        }


    }
}