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
                    { "UserAgent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64)" }
                }
            },
            {
                "WALMART", new Dictionary<string, string>
                {
                    { "img", "Walmart-Logo" },
                    { "Url", "https://www.walmart.com.ni/" },
                    { "Tipo", "VTEX" },
                    { "Activo", "SI" },
                    { "UserAgent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 Chrome/120.0.0.0 Safari/537.36" },
                    { "XPathContenedor", "//*[contains(@class, 'vtex-product-summary')]" },
                    { "XPathTitulo", ".//*[@id='product-summary-sku-name']" },
                    { "XPathPrecio", ".//*[contains(@class, 'price_sellingPrice--summary')]" },
                    { "XPathImagen", ".//img" }
                }
            },
            {
                "La Curacao", new Dictionary<string, string>
                {
                    { "img", "curacao_logo" },
                    { "Url", "https://www.lacuracaonline.com/nicaragua/" },
                    { "Tipo", "MagentoLS" },
                    { "Activo", "SI" },
                    { "UserAgent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 Chrome/120.0.0.0 Safari/537.36" },
                    { "XPathContenedor", "//*[contains(@class,'ds-sdk-product-item')]" },
                    { "XPathTitulo", ".//*[contains(@class,'ds-sdk-product-item__product-name')]" },
                    { "XPathPrecio", ".//*[contains(@class,'price')]" },
                    { "XPathImagen", ".//img" }
                }
            },
            {
                "RadioShack", new Dictionary<string, string>
                {
                    { "img", "RadioShack-Logo" },
                    { "Activo", "SI" },
                    { "Tipo", "MagentoLS" },
                    { "Url", "https://www.radioshackla.com/" },

                    { "GraphQLUrl", "https://catalog-service.adobe.io/graphql" },
                    { "Magento-Customer-Group", "b6589fc6ab0dc82cf12099d1c2d40ab994e8410c" },
                    { "Magento-Environment-Id", "b0453fee-9cca-41d9-930c-0a94fd84b9bd" },
                    { "Magento-Website-Code", "rso_nicaragua_w" },
                    { "Magento-Store-Code", "rso_nicaragua_s" },
                    { "Magento-Store-View-Code", "rso_nicaragua_sv" },
                    { "X-Api-Key", "2999e5a23078490096b15ef87ccc499c" }
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

        // ****   Adision Para Mejorar las busquedas     ****

        public static class FiltrosProductos
        {
            // Diccionario principal de marcas y palabras clave asociadas
            public static readonly Dictionary<string, string[]> Marcas = new Dictionary<string, string[]>(StringComparer.OrdinalIgnoreCase)
            {
                { "Samsung", new[] { "Samsung" } },
                { "Xiaomi", new[] { "Xiaomi", "Redmi", "Poco" } },
                { "HONOR", new[] { "HONOR", "Honor" } },
                { "Motorola", new[] { "Motorola", "Moto" } },
                { "Huawei", new[] { "Huawei" } },
                { "Apple", new[] { "Apple", "iPhone" } },
                { "ZTE", new[] { "ZTE" } },
                { "TCL", new[] { "TCL" } },
                { "Sony", new[] { "TCL" } },

                // Marcas de Línea Blanca / Electrodomésticos / TV
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
                { "ResolucionesTV", new[] { "OLED", "QLED", "LED", "Smart TV", "4K UHD", "Full HD", "HD" } },
                { "MemoriaRAM", new[] { "4GB RAM", "6GB RAM", "8GB RAM", "12GB RAM" } }
            };
        }

        public static readonly Dictionary<string, string[]> parecidos = new Dictionary<string, string[]>(StringComparer.OrdinalIgnoreCase)
        {
            { "celular", new[] { "smartphone", "telefono", "movil" } },
            { "smartphone", new[] { "celular", "telefono" } },
            { "refri", new[] { "refrigeradora", "refrigerador", "nevera" } },
            { "tv", new[] { "televisor", "smart tv", "pantalla" } },
            { "pantalla", new[] { "televisor", "tv", "monitor" } },
            { "lavadora", new[] { "lavadora secadora", "seco-lavadora" } }
        };

        // aqui ya terminan todos los diccionarios XD

        // —————————————————— Revisa qué forma de búsqueda usar según la tienda  ————————————————————————————————๑•̀ᴗ•̀) ̫ ─꒱
        public static async Task<(string, List<ProductoResult>)> ScrapearTiendaAsync(string textoBuscado, KeyValuePair<string, Dictionary<string, string>> tienda)
        {
            if (tienda.Value.TryGetValue("Tipo", out var tipo))
            {
                if (tipo == "Algolia") return await scraping_Algolia(httpClient, textoBuscado, tienda);
                if (tipo == "VTEX") return await scraping_VTEX(httpClient, textoBuscado, tienda);
                if (tienda.Value["Tipo"] == "MagentoLS") return await scraping_MagentoLS(httpClient, textoBuscado, tienda); }
            return await scraping_v1(httpClient, textoBuscado, tienda);
        }

        //Mejora pa rendimiento        
        public static readonly HttpClient httpClient = new HttpClient(new HttpClientHandler
        {
            AllowAutoRedirect = true,
            AutomaticDecompression = System.Net.DecompressionMethods.GZip | System.Net.DecompressionMethods.Deflate | System.Net.DecompressionMethods.Brotli
        });

        public static string ObtenerPrimerPrecio(string precioTexto)
        {
            if (string.IsNullOrWhiteSpace(precioTexto)) return precioTexto;

            // Busca el primer patrón válido de precio (ej: C$89,740.00 o $20,999) y descarta todo lo demás
            var match = System.Text.RegularExpressions.Regex.Match(precioTexto, @"(C\$|\$)\s*[\d,.]+", System.Text.RegularExpressions.RegexOptions.IgnoreCase);

            return match.Success ? match.Value.Trim() : precioTexto;
        }

        // Método auxiliar para realizar peticiones GET y opcionalmente guardar el HTML de diagnóstico sin repetir código
        private static async Task<(int StatusCode, string Content)> RealizarGetAsync(HttpClient client, string url, string userAgent, string rutaDebug = null)
        {
            try
            {
                using var request = new HttpRequestMessage(HttpMethod.Get, url);
                if (!string.IsNullOrEmpty(userAgent)) request.Headers.TryAddWithoutValidation("User-Agent", userAgent);

                using var response = await client.SendAsync(request);
                string content = await response.Content.ReadAsStringAsync();

                if (!string.IsNullOrEmpty(rutaDebug))
                    System.IO.File.WriteAllText(rutaDebug, $"URL: {url}\nSTATUS: {(int)response.StatusCode}\n\n{content}");

                return ((int)response.StatusCode, content);
            }
            catch (Exception ex)
            {
                if (!string.IsNullOrEmpty(rutaDebug))
                    System.IO.File.WriteAllText(rutaDebug, $"ERROR:\n{url}\n{ex}");
                return (0, string.Empty);
            }
        }

        //╰────────────────➤[La Magia 🥷]

        // BÚSQUEDA TRADICIONAL - Entra a la página web y lee el diseño HTML para sacar los productos.
        public static async Task<(string, List<ProductoResult>)> scraping_v1(HttpClient client, string textoBuscado, KeyValuePair<string, Dictionary<string, string>> tienda)
        {
            List<ProductoResult> productosEncontrados = new List<ProductoResult>();
            string escritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string rutaTxtPrueba = System.IO.Path.Combine(escritorio, "radioshack_debug.txt");

            // Prepara el texto que escribiste para que la página web lo entienda en el enlace.
            string textoCodificado = Uri.EscapeDataString(textoBuscado);
            string urlBusqueda = tienda.Value["Url"] + textoCodificado + tienda.Value.GetValueOrDefault("UrlParametros", "");
            string userAgent = tienda.Value.GetValueOrDefault("UserAgent", "");

            var (status, html) = await RealizarGetAsync(client, urlBusqueda, userAgent, rutaTxtPrueba);
            if (status != 200 || string.IsNullOrEmpty(html)) return (tienda.Key, productosEncontrados);

            // Lee todo el código de la página web.
            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(html);

            // Busca las cajitas donde están guardados los productos en la página.
            string xpathContenedor = tienda.Value.GetValueOrDefault("XPathContenedor", "//*[contains(@class, 'product') and not(contains(@class, 'category'))]");
            var nodosProductos = doc.DocumentNode.SelectNodes(xpathContenedor);

            if (nodosProductos != null)
            {
                int count = 0;
                string[] palabrasExcluidas = tienda.Value.GetValueOrDefault("ExcluirNombres", "").Split('|', StringSplitOptions.RemoveEmptyEntries);
                string[] terminosOmitir = { "Añadir al carrito", "Agregar a Lista de deseos", "Leer más" };
                string xpathTitulo = tienda.Value.GetValueOrDefault("XPathTitulo", ".//*[contains(@class, 'title') or contains(@class, 'name') or name()='h2' or name()='h3']");
                string xpathPrecio = tienda.Value.GetValueOrDefault("XPathPrecio", ".//ins//bdi | .//bdi | .//*[contains(@class, 'electro-price')] | .//*[contains(@class, 'price')]");
                string xpathImagen = tienda.Value.GetValueOrDefault("XPathImagen", ".//img");

                // Revisa cada cajita de producto encontrada.
                foreach (var nodo in nodosProductos)
                {
                    if (count >= 1000) break;
                    var nodoTitulo = nodo.SelectSingleNode(xpathTitulo);
                    var nodoPrecio = nodo.SelectSingleNode(xpathPrecio);
                    var nodoImagen = nodo.SelectSingleNode(xpathImagen);

                    // Limpia el nombre y el precio
                    string nombre = nodoTitulo != null ? System.Net.WebUtility.HtmlDecode(nodoTitulo.InnerText.Trim()).Replace("\n", " ").Replace("\r", "") : "";
                    string precio = nodoPrecio != null ? System.Net.WebUtility.HtmlDecode(nodoPrecio.InnerText.Trim()).Replace("\n", " ").Replace("\r", "") : "Sin precio";

                    foreach (var term in terminosOmitir) { precio = precio.Replace(term, ""); }
                    precio = precio.Trim();

                    // Extracción de enlace (Hipervínculo)
                    var nodoAncla = nodo.SelectSingleNode(".//a") ?? (nodoTitulo != null ? nodoTitulo.SelectSingleNode("ancestor-or-self::a") : null);
                    string href = nodoAncla != null ? nodoAncla.GetAttributeValue("href", "") : "";
                    string urlFinal = "";
                    if (!string.IsNullOrEmpty(href))
                    {
                        urlFinal = href.StartsWith("http") ? href : new Uri(new Uri(tienda.Value["Url"]), href).ToString();
                    }

                    // Extracción de Imagen
                    string imagenUrl = nodoImagen != null ? nodoImagen.GetAttributeValue("src", "") : "";

                    // Comprueba que el producto tenga nombre y no sea una palabra random o basura.
                    bool esValido = !string.IsNullOrEmpty(nombre);
                    foreach (var palabra in palabrasExcluidas) { if (nombre.Contains(palabra, StringComparison.OrdinalIgnoreCase)) { esValido = false; break; } }

                    if (esValido)
                    {
                        // Guarda el producto limpio en nuestra lista.
                        productosEncontrados.Add(new ProductoResult
                        {
                            Nombre = nombre,
                            PrecioTexto = precio,
                            PrecioMonto = Utilidad.LimpiarPrecio(precio),
                            TiendaKey = tienda.Key,
                            Url = urlFinal,
                            Imagen = imagenUrl
                        });
                        count++;
                    }
                }
            }
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

                                    // Extracción de URL e Imagen desde Algolia
                                    string urlProducto = hit.TryGetProperty("url", out var uProp) ? uProp.GetString() ?? "" : "";
                                    if (!string.IsNullOrEmpty(urlProducto) && !urlProducto.StartsWith("http"))
                                    {
                                        urlProducto = $"https://www.elgallomasgallo.com.ni{urlProducto}";
                                    }

                                    string imagenUrl = hit.TryGetProperty("image", out var iProp) ? iProp.GetString() ?? "" : "";

                                    if (!string.IsNullOrEmpty(nombre))
                                    {
                                        if (precioMonto == decimal.MaxValue) precioMonto = Utilidad.LimpiarPrecio(precioTexto);
                                        productosEncontrados.Add(new ProductoResult
                                        {
                                            Nombre = nombre,
                                            PrecioTexto = precioTexto,
                                            PrecioMonto = precioMonto,
                                            TiendaKey = tienda.Key,
                                            Url = urlProducto,
                                            Imagen = imagenUrl
                                        });
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

        // BÚSQUEDA POR VTEX
        public static async Task<(string, List<ProductoResult>)> scraping_VTEX(HttpClient client, string textoBuscado, KeyValuePair<string, Dictionary<string, string>> tienda)
        {
            var productos = new List<ProductoResult>();
            string baseUrl = tienda.Value["Url"].TrimEnd('/'), termino = Uri.EscapeDataString(textoBuscado.Trim());
            string rutaDebug = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "walmart_vtex_debug.txt");

            // 1. API VTEX
            foreach (string urlAPI in new[] { $"{baseUrl}/api/catalog_system/pub/products/search/{termino}?_from=0&_to=49", $"{baseUrl}/api/catalog_system/pub/products/search?ft={termino}&_from=0&_to=49" })
            {
                try
                {
                    using var request = new HttpRequestMessage(HttpMethod.Get, urlAPI);
                    request.Headers.TryAddWithoutValidation("User-Agent", tienda.Value.GetValueOrDefault("UserAgent", "Mozilla/5.0"));
                    request.Headers.Accept.ParseAdd("application/json");
                    request.Headers.Referrer = new Uri(baseUrl + "/");

                    using var response = await client.SendAsync(request);
                    string json = await response.Content.ReadAsStringAsync();
                    System.IO.File.WriteAllText(rutaDebug, $"URL: {urlAPI}\nSTATUS: {(int)response.StatusCode}\n\n{json}");
                    if (!response.IsSuccessStatusCode) continue;

                    using var doc = JsonDocument.Parse(json);
                    if (doc.RootElement.ValueKind != JsonValueKind.Array) continue;

                    foreach (JsonElement prod in doc.RootElement.EnumerateArray())
                    {
                        string nombre = ObtenerTextoVTEX(prod, "productName");
                        if (string.IsNullOrWhiteSpace(nombre)) nombre = ObtenerTextoVTEX(prod, "productTitle");
                        if (string.IsNullOrWhiteSpace(nombre)) continue;

                        string enlace = ObtenerTextoVTEX(prod, "link");
                        if (string.IsNullOrWhiteSpace(enlace))
                        {
                            string slug = ObtenerTextoVTEX(prod, "linkText");
                            if (!string.IsNullOrWhiteSpace(slug)) enlace = $"/{slug}/p";
                        }

                        string imagen = "";
                        decimal? precio = null;

                        if (prod.TryGetProperty("items", out JsonElement items) && items.ValueKind == JsonValueKind.Array)
                        {
                            foreach (JsonElement item in items.EnumerateArray())
                            {
                                if (string.IsNullOrWhiteSpace(imagen) && item.TryGetProperty("images", out JsonElement imgs) && imgs.ValueKind == JsonValueKind.Array && imgs.GetArrayLength() > 0)
                                    imagen = ObtenerTextoVTEX(imgs[0], "imageUrl");

                                if (item.TryGetProperty("sellers", out JsonElement sellers) && sellers.ValueKind == JsonValueKind.Array)
                                {
                                    foreach (JsonElement seller in sellers.EnumerateArray())
                                    {
                                        if (!seller.TryGetProperty("commertialOffer", out JsonElement oferta)) continue;
                                        precio = ObtenerDecimalVTEX(oferta, "Price") ?? ObtenerDecimalVTEX(oferta, "PriceWithoutDiscount");
                                        if (precio.HasValue) break;
                                    }
                                }
                                if (precio.HasValue && !string.IsNullOrWhiteSpace(imagen)) break;
                            }
                        }

                        string precioTexto = precio.HasValue ? $"C$ {precio.Value.ToString("#,##0.00", System.Globalization.CultureInfo.InvariantCulture)}" : "Sin precio";
                        productos.Add(new ProductoResult { Nombre = nombre, PrecioTexto = precioTexto, PrecioMonto = precio ?? Utilidad.LimpiarPrecio(precioTexto), TiendaKey = tienda.Key, Url = ResolverUrlVTEX(baseUrl, enlace), Imagen = ResolverUrlVTEX(baseUrl, imagen) });
                    }
                    if (productos.Count > 0) return (tienda.Key, productos);
                }
                catch (Exception ex) { System.IO.File.WriteAllText(rutaDebug, $"ERROR API:\n{urlAPI}\n{ex}"); }
            }

            // 2. Respaldo mediante HTML
            try
            {
                string slug = Uri.EscapeDataString(textoBuscado.Trim().Replace(" ", "-").ToLowerInvariant());
                string urlBusqueda = $"{baseUrl}/{slug}?_q={termino}&map=ft";
                var (status, html) = await RealizarGetAsync(client, urlBusqueda, tienda.Value.GetValueOrDefault("UserAgent", ""), rutaDebug);
                if (status != 200) return (tienda.Key, productos);

                var docHtml = new HtmlAgilityPack.HtmlDocument();
                docHtml.LoadHtml(html);

                string xpathCont = tienda.Value.GetValueOrDefault("XPathContenedor", "//*[contains(@class,'vtex-product-summary')]");
                string xpathTit = tienda.Value.GetValueOrDefault("XPathTitulo", ".//*[@id='product-summary-sku-name']");
                string xpathPrec = tienda.Value.GetValueOrDefault("XPathPrecio", ".//*[contains(@class,'price_sellingPrice--summary')]");
                string xpathImg = tienda.Value.GetValueOrDefault("XPathImagen", ".//img");

                var nodos = docHtml.DocumentNode.SelectNodes(xpathCont);
                if (nodos != null)
                {
                    foreach (var nodo in nodos)
                    {
                        string nombre = System.Net.WebUtility.HtmlDecode(nodo.SelectSingleNode(xpathTit)?.InnerText.Trim() ?? "");
                        if (string.IsNullOrWhiteSpace(nombre)) continue;

                        string precioTexto = System.Net.WebUtility.HtmlDecode(nodo.SelectSingleNode(xpathPrec)?.InnerText.Trim() ?? "Sin precio");
                        var imgNode = nodo.SelectSingleNode(xpathImg);
                        string imgUrl = imgNode?.GetAttributeValue("src", "") ?? "";
                        if (string.IsNullOrWhiteSpace(imgUrl)) imgUrl = imgNode?.GetAttributeValue("data-src", "") ?? "";

                        productos.Add(new ProductoResult { Nombre = nombre, PrecioTexto = precioTexto, PrecioMonto = Utilidad.LimpiarPrecio(precioTexto), TiendaKey = tienda.Key, Url = ResolverUrlVTEX(baseUrl, nodo.SelectSingleNode(".//a")?.GetAttributeValue("href", "") ?? ""), Imagen = ResolverUrlVTEX(baseUrl, imgUrl) });
                    }
                }
            }
            catch (Exception ex) { System.IO.File.WriteAllText(rutaDebug, "ERROR HTML:\n" + ex); }

            return (tienda.Key, productos);
        }

        // AUXILIARES VTEX
        private static string ObtenerTextoVTEX(JsonElement obj, string prop) => obj.TryGetProperty(prop, out JsonElement val) && (val.ValueKind == JsonValueKind.String || val.ValueKind == JsonValueKind.Number) ? val.ToString() : "";

        private static decimal? ObtenerDecimalVTEX(JsonElement obj, string prop)
        {
            if (!obj.TryGetProperty(prop, out JsonElement val)) return null;
            if (val.ValueKind == JsonValueKind.Number && val.TryGetDecimal(out decimal num)) return num;
            return val.ValueKind == JsonValueKind.String && decimal.TryParse(val.GetString(), System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out decimal parsed) ? parsed : null;
        }

        private static string ResolverUrlVTEX(string baseUrl, string url)
        {
            if (string.IsNullOrWhiteSpace(url)) return "";
            if (url.StartsWith("//")) return "https:" + url;
            if (Uri.TryCreate(url, UriKind.Absolute, out var abs) && abs != null) return abs.ToString();
            return Uri.TryCreate(new Uri(baseUrl + "/"), url.TrimStart('/'), out var rel) && rel != null ? rel.ToString() : "";
        }





        // BÚSQUEDA POR MAGENTO LIVE SEARCH
        public static async Task<(string, List<ProductoResult>)> scraping_MagentoLS(HttpClient client, string textoBuscado, KeyValuePair<string, Dictionary<string, string>> tienda)

        {
            var productos = new List<ProductoResult>();
            var debug = new System.Text.StringBuilder();
            string rutaDebug = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), $"MagentoLS_{tienda.Key.Replace(" ", "_")}_debug.txt");

            try
            {
                string termino = textoBuscado.Trim();
                string endpoint = tienda.Value.GetValueOrDefault("GraphQLUrl", "https://catalog-service.adobe.io/graphql");
                const int pageSize = 24;

                const string query = """
        query productSearch($phrase: String!, $pageSize: Int, $currentPage: Int = 1, $filter: [SearchClauseInput!], $sort: [ProductSearchSortInput!], $context: QueryContextInput) {
            productSearch(phrase: $phrase, page_size: $pageSize, current_page: $currentPage, filter: $filter, sort: $sort, context: $context) {
                total_count
                items {
                    product {
                        name
                        canonical_url
                        small_image { url }
                        image { url }
                        price_range {
                            minimum_price {
                                final_price { value currency }
                            }
                        }
                    }
                    productView {
                        name
                        url
                        images { url roles }
                        ... on SimpleProductView {
                            price {
                                final {
                                    amount { value currency }
                                }
                            }
                        }
                        ... on ComplexProductView {
                            priceRange {
                                minimum {
                                    final {
                                        amount { value currency }
                                    }
                                }
                            }
                        }
                    }
                }
                page_info { current_page page_size total_pages }
            }
        }
        """;

                JsonElement Prop(JsonElement elemento, string propiedad)
                {
                    return elemento.ValueKind == JsonValueKind.Object && elemento.TryGetProperty(propiedad, out var valor) ? valor : default;
                }

                string Texto(JsonElement elemento, string propiedad)
                {
                    var valor = Prop(elemento, propiedad);
                    return valor.ValueKind == JsonValueKind.String ? valor.GetString() ?? "" : "";
                }

                decimal? Numero(JsonElement elemento, params string[] ruta)
                {
                    foreach (string propiedad in ruta)
                    {
                        elemento = Prop(elemento, propiedad);
                        if (elemento.ValueKind == JsonValueKind.Undefined || elemento.ValueKind == JsonValueKind.Null) return null;
                    }
                    if (elemento.ValueKind == JsonValueKind.Number && elemento.TryGetDecimal(out decimal numero)) return numero;
                    return null;
                }

                string ResolverUrl(string url)
                {
                    if (string.IsNullOrWhiteSpace(url)) return "";
                    if (url.StartsWith("//")) return "https:" + url;
                    if (Uri.TryCreate(url, UriKind.Absolute, out var absoluta)) return absoluta.ToString();
                    return Uri.TryCreate(new Uri(endpoint), url, out var relativa) ? relativa.ToString() : "";
                }

                string ObtenerImagen(JsonElement producto, JsonElement vista)
                {
                    var imagenes = Prop(vista, "images");
                    if (imagenes.ValueKind == JsonValueKind.Array)
                    {
                        JsonElement primera = default;
                        JsonElement preferida = default;
                        foreach (var img in imagenes.EnumerateArray())
                        {
                            if (primera.ValueKind == JsonValueKind.Undefined) primera = img;
                            var roles = Prop(img, "roles");
                            if (roles.ValueKind == JsonValueKind.Array)
                            {
                                foreach (var rol in roles.EnumerateArray())
                                {
                                    string valor = rol.GetString() ?? "";
                                    if (valor == "image") { preferida = img; break; }
                                    if (valor == "small_image" && preferida.ValueKind == JsonValueKind.Undefined) preferida = img;
                                }
                            }
                            if (preferida.ValueKind != JsonValueKind.Undefined)
                            {
                                var rolesActuales = Prop(preferida, "roles");
                                if (rolesActuales.ValueKind == JsonValueKind.Array && System.Linq.Enumerable.Contains(System.Linq.Enumerable.Select(rolesActuales.EnumerateArray(), r => r.GetString()), "image")) break;
                            }
                        }

                        var seleccionada = preferida.ValueKind != JsonValueKind.Undefined ? preferida : primera;
                        string url = Texto(seleccionada, "url");
                        if (!string.IsNullOrWhiteSpace(url)) return ResolverUrl(url);
                    }

                    string alternativa = Texto(Prop(producto, "small_image"), "url");
                    if (string.IsNullOrWhiteSpace(alternativa)) alternativa = Texto(Prop(producto, "image"), "url");
                    if (string.IsNullOrWhiteSpace(alternativa)) alternativa = Texto(Prop(producto, "thumbnail"), "url");
                    return ResolverUrl(alternativa);
                }

                var duplicados = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
                int pagina = 1;
                int totalPaginas = 1;

                debug.AppendLine("TIENDA: " + tienda.Key);
                debug.AppendLine("BÚSQUEDA: " + termino);
                debug.AppendLine("ENDPOINT: " + endpoint);

                do
                {
                    var payload = new
                    {
                        query = query,
                        variables = new
                        {
                            phrase = termino,
                            pageSize = pageSize,
                            currentPage = pagina,
                            filter = new object[]
                            {
                        new { attribute = "visibility", @in = new[] { "Search", "Catalog, Search" } },
                        new { attribute = "inStock", eq = "true" },
                        new { attribute = "price", range = new { from = 0, to = 999998 } }
                            },
                            sort = new[]
                            {
                        new { attribute = "relevance", direction = "DESC" }
                    },
                            context = new
                            {
                                customerGroup = tienda.Value.GetValueOrDefault("CustomerGroup", "b6589fc6ab0dc82cf12099d1c2d40ab994e8410c"),
                                userViewHistory = Array.Empty<object>()
                            }
                        }
                    };

                    string jsonBody = System.Text.Json.JsonSerializer.Serialize(payload);

                    using var request = new HttpRequestMessage(HttpMethod.Post, endpoint);
                    request.Content = new StringContent(jsonBody, System.Text.Encoding.UTF8, "application/json");
                    request.Headers.Accept.ParseAdd("application/json");

                    string[] encabezados =
                    {
                "Magento-Environment-Id",
                "Magento-Website-Code",
                "Magento-Store-Code",
                "Magento-Store-View-Code",
                "X-Api-Key"
            };

                    debug.AppendLine();
                    debug.AppendLine($"========== PÁGINA {pagina} ==========");
                    debug.AppendLine("REQUEST URL: " + endpoint);
                    debug.AppendLine("METHOD: POST");
                    debug.AppendLine("PAYLOAD:");
                    debug.AppendLine(jsonBody);

                    foreach (string encabezado in encabezados)
                    {
                        string valor = tienda.Value.GetValueOrDefault(encabezado, "");
                        if (!string.IsNullOrWhiteSpace(valor))
                            request.Headers.TryAddWithoutValidation(encabezado, valor);
                        else
                            debug.AppendLine("FALTA ENCABEZADO: " + encabezado);
                    }

                    using var response = await client.SendAsync(request);
                    string respuesta = await response.Content.ReadAsStringAsync();

                    debug.AppendLine("STATUS: " + (int)response.StatusCode);
                    debug.AppendLine("RESPONSE:");
                    debug.AppendLine(respuesta);

                    if (!response.IsSuccessStatusCode)
                        break;

                    using var documento = JsonDocument.Parse(respuesta);
                    var raiz = documento.RootElement;

                    var errores = Prop(raiz, "errors");
                    if (errores.ValueKind == JsonValueKind.Array && errores.GetArrayLength() > 0)
                    {
                        debug.AppendLine("GRAPHQL ERRORS: " + errores.GetRawText());
                        break;
                    }

                    var data = Prop(raiz, "data");
                    var busqueda = Prop(data, "productSearch");
                    var items = Prop(busqueda, "items");

                    if (items.ValueKind != JsonValueKind.Array || items.GetArrayLength() == 0)
                        break;

                    var informacionPagina = Prop(busqueda, "page_info");
                    totalPaginas = (int)(Numero(informacionPagina, "total_pages") ?? 1);

                    foreach (var item in items.EnumerateArray())
                    {
                        if (productos.Count >= 1000) break;

                        var producto = Prop(item, "product");
                        var vista = Prop(item, "productView");

                        string nombre = Texto(producto, "name");
                        if (string.IsNullOrWhiteSpace(nombre)) nombre = Texto(vista, "name");
                        nombre = System.Net.WebUtility.HtmlDecode(nombre).Trim();
                        if (string.IsNullOrWhiteSpace(nombre)) continue;

                        string url = ResolverUrl(Texto(vista, "url"));
                        if (string.IsNullOrWhiteSpace(url))
                            url = ResolverUrl(Texto(producto, "canonical_url"));

                        string imagen = ObtenerImagen(producto, vista);

                        decimal? monto =
                            Numero(vista, "price", "final", "amount", "value") ??
                            Numero(vista, "priceRange", "minimum", "final", "amount", "value") ??
                            Numero(producto, "price_range", "minimum_price", "final_price", "value");

                        string precioTexto = monto.HasValue
                            ? "C$ " + monto.Value.ToString("#,##0.00", System.Globalization.CultureInfo.InvariantCulture)
                            : "Sin precio";

                        string clave = !string.IsNullOrWhiteSpace(url) ? url : nombre;
                        if (!duplicados.Add(clave)) continue;

                        productos.Add(new ProductoResult
                        {
                            Nombre = nombre,
                            PrecioTexto = precioTexto,
                            PrecioMonto = monto ?? Utilidad.LimpiarPrecio(precioTexto),
                            TiendaKey = tienda.Key,
                            Url = url,
                            Imagen = imagen
                        });
                    }

                    pagina++;

                } while (pagina <= totalPaginas && productos.Count < 1000);

                debug.AppendLine();
                debug.AppendLine("========== RESULTADO FINAL ==========");
                debug.AppendLine("PRODUCTOS ENCONTRADOS: " + productos.Count);
                debug.AppendLine("PÁGINAS CONSULTADAS: " + (pagina - 1));

            }
            catch (Exception ex)
            {
                debug.AppendLine("ERROR GENERAL:");
                debug.AppendLine(ex.ToString());
                System.Diagnostics.Debug.WriteLine($"Error MagentoLS ({tienda.Key}): {ex}");
            }
            finally
            {
                try
                {
                    await System.IO.File.WriteAllTextAsync(rutaDebug, debug.ToString(), System.Text.Encoding.UTF8);
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine("Error guardando debug MagentoLS: " + ex.Message);
                }
            }

            return (tienda.Key, productos);
        }





    }
}