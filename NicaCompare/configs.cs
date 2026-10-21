using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static System.Resources.ResXFileRef;

namespace NicaCompare
{
    public static class ConfigScraper
    {

        // ┌─────────────────◦(●￣ ⚙️ Configuracion de scraping por tienda ⚙️ ￣●)◦────────────────────┐
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

                }
            },
            {
                "La Curacao Nicaragua", new Dictionary<string, string>
                {
                    { "img", "curacao_logo" },
                    { "Url", "https://www.lacuracaonline.com/nicaragua/catalogsearch/result/?q=" },
                    { "Activo", "SI" },
                    { "UserAgent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 Chrome/120.0.0.0 Safari/537.36" },
                    { "XPathContenedor", "//li[contains(@class, 'product-item')]" },
                    { "XPathTitulo", ".//a[contains(@class, 'product-item-link')]" },
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


        // ****   Adision Para Mejorar las busquedas      ****

        public static class FiltrosProductos
        {
            // Diccionario principal de marcas y palabras clave asociadas
            public static readonly Dictionary<string, string[]> Marcas = new Dictionary<string, string[]>(StringComparer.OrdinalIgnoreCase)
            {
            { "Samsung", new[] { "Samsung" } },
            { "LG", new[] { "LG" } },
            { "Hisense", new[] { "Hisense" } },
            { "Frigidaire", new[] { "Frigidaire" } },
            { "Telstar", new[] { "Telstar" } },
            { "RCA", new[] { "RCA" } },
            { "Konka", new[] { "Konka" } },
            { "Challenger", new[] { "Challenger" } },
            { "Premier", new[] { "Premier" } },
            { "G-PLUS", new[] { "G-PLUS", "GPLUS" } }
            };

            // Diccionario de especificaciones por categoría o tipo de producto
            public static readonly Dictionary<string, string[]> Atributos = new Dictionary<string, string[]>(StringComparer.OrdinalIgnoreCase)
            {
            { "TipoOperacion", new[] { "Semiautomática", "Automática", "Congelador Horizontal" } },
            { "Resoluciones", new[] { "OLED", "QLED", "LED", "Smart TV", "4K UHD", "Full HD", "HD" } }
            };
            }

        // —————————————————— Revisa qué forma de búsqueda usar según la tienda  ————————————————————————————————๑•̀ᴗ•̀) ̫ ─꒱
        public static async Task<(string, List<ProductoResult>)> ScrapearTiendaAsync(HttpClient client, string textoBuscado, KeyValuePair<string, Dictionary<string, string>> tienda)
        {
            if (tienda.Value.ContainsKey("Tipo"))
            {
                if (tienda.Value["Tipo"] == "Algolia") { return await scraping_Algolia(client, textoBuscado, tienda); }
                //else if (tienda.Value["Tipo"] == "Constructor") { return await scraping_Constructor(client, textoBuscado, tienda); }
            }
            return await scraping_v1(client, textoBuscado, tienda);
        }

        // LIMPIAR PRECIO - Quita letras, símbolos de moneda y espacios para dejar sólo el número puro.
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
                .Replace("+ IVA", "")
                .Replace("IVA", "")
                .Trim();
            // Convierte él texto limpio en un numero pa que no crashee y poder ordenar
            if (decimal.TryParse(limpio, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out decimal resultado)) { return resultado; }

            return decimal.MaxValue;
        }

        //╰────────────────➤[La Magia 🥷]

        // BÚSQUEDA TRADICIONAL - Entra a la página web y lee el diseño HTML para sacar los productos.
        public static async Task<(string, List<ProductoResult>)> scraping_v1(HttpClient client, string textoBuscado, KeyValuePair<string, Dictionary<string, string>> tienda)
        {
            List<ProductoResult> productosEncontrados = new List<ProductoResult>();
            try
            {
                // Prepara el texto que escribiste para que la página web lo entienda en el enlace.
                string textoCodificado = Uri.EscapeDataString(textoBuscado);
                string urlBusqueda = tienda.Value["Url"] + textoCodificado + (tienda.Value.ContainsKey("UrlParametros") ? tienda.Value["UrlParametros"] : "");

                using (var request = new HttpRequestMessage(HttpMethod.Get, urlBusqueda))
                {
                    if (tienda.Value.ContainsKey("UserAgent")) { request.Headers.Add("User-Agent", tienda.Value["UserAgent"]); }

                    var response = await client.SendAsync(request);
                    if (response.IsSuccessStatusCode)
                    {
                        // Lee todo el código de la página web.
                        string html = await response.Content.ReadAsStringAsync();
                        HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
                        doc.LoadHtml(html);

                        // Busca las cajitas donde están guardados los productos en la página.
                        string xpathContenedor = tienda.Value.ContainsKey("XPathContenedor") ? tienda.Value["XPathContenedor"] : "//*[contains(@class, 'product') and not(contains(@class, 'category'))]";
                        var nodosProductos = doc.DocumentNode.SelectNodes(xpathContenedor);

                        if (nodosProductos != null)
                        {
                            int count = 0;
                            string[] palabrasExcluidas = tienda.Value.ContainsKey("ExcluirNombres") ? tienda.Value["ExcluirNombres"].Split('|') : new string[0];
                            string[] terminosOmitir = { "Añadir al carrito", "Agregar a Lista de deseos", "Leer más" };
                            string xpathTitulo = tienda.Value.ContainsKey("XPathTitulo") ? tienda.Value["XPathTitulo"] : ".//*[contains(@class, 'title') or contains(@class, 'name') or name()='h2' or name()='h3']";
                            string xpathPrecio = tienda.Value.ContainsKey("XPathPrecio") ? tienda.Value["XPathPrecio"] : ".//ins//bdi | .//bdi | .//*[contains(@class, 'electro-price')] | .//*[contains(@class, 'price')]";

                            // Revisa cada cajita de producto encontrada.
                            foreach (var nodo in nodosProductos)
                            {
                                if (count >= 1000) break;
                                var nodoTitulo = nodo.SelectSingleNode(xpathTitulo);
                                var nodoPrecio = nodo.SelectSingleNode(xpathPrecio);

                                // Limpia el nombre y el precio
                                string nombre = nodoTitulo != null ? System.Net.WebUtility.HtmlDecode(nodoTitulo.InnerText.Trim()).Replace("\n", " ").Replace("\r", "") : "";
                                string precio = nodoPrecio != null ? System.Net.WebUtility.HtmlDecode(nodoPrecio.InnerText.Trim()).Replace("\n", " ").Replace("\r", "") : "Sin precio";

                                foreach (var term in terminosOmitir) { precio = precio.Replace(term, ""); }
                                precio = precio.Trim();

                                // Comprueba que el producto tenga nombre y no sea una palabra random o basura.
                                bool esValido = !string.IsNullOrEmpty(nombre);
                                foreach (var palabra in palabrasExcluidas) { if (nombre.Contains(palabra, StringComparison.OrdinalIgnoreCase)) { esValido = false; break; } }

                                if (esValido)
                                {
                                    // Guarda el producto limpio en nuestra lista.
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


        // BÚSQUEDA POR ALGOLIA - Consulta directamente al buscador inteligente de la tienda usando datos ocultos.
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
                    // Añade las llaves especiales que pide la tienda para dejarnos buscar en su sistema.
                    req.Headers.Add("X-Algolia-Application-Id", tienda.Value["AlgoliaAppId"]);
                    req.Headers.Add("X-Algolia-API-Key", tienda.Value["AlgoliaApiKey"]);
                    req.Content = new StringContent(jsonBody, Encoding.UTF8, "application/json");

                    var resp = await client.SendAsync(req);
                    if (resp.IsSuccessStatusCode)
                    {
                        string jsonRes = await resp.Content.ReadAsStringAsync();
                        using (var doc = JsonDocument.Parse(jsonRes))
                        {
                            // Revisa si la tienda nos devolvió resultados en formato de datos (JSON).
                            if (doc.RootElement.TryGetProperty("hits", out var hits) && hits.ValueKind == JsonValueKind.Array)
                            {
                                foreach (var hit in hits.EnumerateArray())
                                {
                                    string nombre = hit.TryGetProperty("name", out var nProp) ? nProp.GetString() ?? "" : "";
                                    string precioTexto = "Sin precio";
                                    decimal precioMonto = decimal.MaxValue;

                                    // Saca el precio en moneda local (NIO).
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
            }
            catch { }
            return (tienda.Key, productosEncontrados);
        }


    }
}