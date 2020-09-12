using Msp.Infrastructure.Extensions;
using Msp.Infrastructure.RouteMap;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Msp.Service.Http
{
    public class HttpService : IDisposable
    {
        private bool disposed = false;
        private HttpClient _httpClient;
        protected readonly string serviceBaseAddress;
        private readonly string addressSuffix;
        private readonly string jsonMediaType = "application/json";
        private RouteMapDTO routeMapDto;

        public HttpService(string serviceBaseAddress)
        {
            this.serviceBaseAddress = serviceBaseAddress;
            _httpClient = GetHttpClientWithToken(serviceBaseAddress, "");
        }

        public HttpService(string serviceBaseAddress, string addressSuffix, string token)
        {
            this.serviceBaseAddress = serviceBaseAddress;
            this.addressSuffix = addressSuffix;
            _httpClient = GetHttpClientWithToken(serviceBaseAddress, token);
        }

        public HttpService(string serviceBaseAddress, string addressSuffix)
        {
            _httpClient = GetHttpClientWithToken(serviceBaseAddress, "");
            this.addressSuffix = addressSuffix;
        }

        protected virtual HttpClient GetHttpClientWithToken(string serviceBaseAddress, string token)
        {
            HttpClientHandler handler = new HttpClientHandler()
            {
                AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate
            };
            _httpClient = new HttpClient(handler);


            _httpClient.BaseAddress = new Uri(serviceBaseAddress);
            if (!string.IsNullOrEmpty(token))
            {
                _httpClient.DefaultRequestHeaders.Add("Authorization", token);
            }
            else
            {
                _httpClient.DefaultRequestHeaders.Remove("Authorization");
            }
            _httpClient.DefaultRequestHeaders.Accept.Add(MediaTypeWithQualityHeaderValue.Parse(jsonMediaType));
            _httpClient.DefaultRequestHeaders.AcceptEncoding.Add(StringWithQualityHeaderValue.Parse("gzip"));
            _httpClient.DefaultRequestHeaders.AcceptEncoding.Add(StringWithQualityHeaderValue.Parse("deflate"));
            _httpClient.DefaultRequestHeaders.UserAgent.Add(new ProductInfoHeaderValue(new ProductHeaderValue("SednaAccounting_HttpClient", "1.0")));
            return _httpClient;
        }


        public T Send<T>(Dictionary<string, object> parameters) where T : class
        {
            HttpResponseMessage httpResponseMessage;
            HttpContent httpContent = null;
            UriBuilder uriBuilder = new UriBuilder(_httpClient.BaseAddress + routeMapDto.Route);
            var queryParamters = HttpUtility.ParseQueryString(string.Empty);
            foreach (var item in parameters)
            {

                if (item.Value.GetType().IsSimpleType())
                {
                    if (item.Value is DateTime)
                        queryParamters[item.Key] = Convert.ToDateTime(item.Value).ToString("yyyy-MM-dd HH:mm:ss");
                    else
                        queryParamters[item.Key] = item.Value.ToString();
                }
                else
                {
                    httpContent = CreateJsonObjectContent(item.Value);
                }
            }

            uriBuilder.Query = queryParamters.ToString();
            HttpRequestMessage httpRequestMessage = new HttpRequestMessage()
            {
                Method = routeMapDto.HttpMethod,
                RequestUri = uriBuilder.Uri,
                Content = httpContent
            };

            httpResponseMessage = _httpClient.SendAsync(httpRequestMessage).Result;
            var result = httpResponseMessage.Content.ReadAsStringAsync().Result;
            if (httpResponseMessage.StatusCode == HttpStatusCode.OK || httpResponseMessage.StatusCode == HttpStatusCode.NoContent)
            {
                if (!string.IsNullOrEmpty(result))
                {
                    return JsonConvert.DeserializeObject<T>(result);
                }
                else
                {
                    return null;
                }
            }
            else
            {
                throw new Exception(result);
            }

        }

        public async Task<T> SendAsync<T>(Dictionary<string, object> parameters) where T : class
        {
            //HttpResponseMessage httpResponseMessage;
            HttpContent httpContent = null;
            UriBuilder uriBuilder = new UriBuilder(_httpClient.BaseAddress + routeMapDto.Route);
            var queryParamters = HttpUtility.ParseQueryString(string.Empty);
            foreach (var item in parameters)
            {

                if (item.Value.GetType().IsSimpleType())
                {
                    if (item.Value is DateTime)
                        queryParamters[item.Key] = Convert.ToDateTime(item.Value).ToString("yyyy-MM-dd HH:mm:ss");
                    else
                        queryParamters[item.Key] = item.Value.ToString();
                }
                else
                {
                    httpContent = CreateJsonObjectContent(item.Value);
                }
            }

            uriBuilder.Query = queryParamters.ToString();
            HttpRequestMessage httpRequestMessage = new HttpRequestMessage()
            {
                Method = routeMapDto.HttpMethod,
                RequestUri = uriBuilder.Uri,
                Content = httpContent
            };

            var httpResponseMessage = await _httpClient.SendAsync(httpRequestMessage);
            var result = await httpResponseMessage.Content.ReadAsStringAsync();
            if (httpResponseMessage.IsSuccessStatusCode || httpResponseMessage.StatusCode == HttpStatusCode.NoContent)
            {
                if (!string.IsNullOrEmpty(result))
                {
                    return JsonConvert.DeserializeObject<T>(result);
                }
                else
                {
                    return null;
                }
            }
            else
            {
                throw new Exception(result);
            }

        }

        public async Task<T> GetAsync<T>() where T : class
        {
            var responseMessage = await _httpClient.GetAsync(addressSuffix);
            var result = await responseMessage.Content.ReadAsStringAsync();
            if (responseMessage.StatusCode == HttpStatusCode.OK || responseMessage.StatusCode == HttpStatusCode.NoContent)
            {
                if (!string.IsNullOrEmpty(result))
                {
                    return JsonConvert.DeserializeObject<T>(result);
                }
                else
                {
                    return null;
                }
            }
            else
            {
                throw new Exception(result);
            }
        }
        public T Get<T>() where T : class
        {
            var responseMessage = _httpClient.GetAsync(addressSuffix).Result;
            var result = responseMessage.Content.ReadAsStringAsync().Result;
            if (responseMessage.StatusCode == HttpStatusCode.OK || responseMessage.StatusCode == HttpStatusCode.NoContent)
            {
                if (!string.IsNullOrEmpty(result))
                {
                    return JsonConvert.DeserializeObject<T>(result);
                }
                else
                {
                    return null;
                }
            }
            else
            {
                throw new Exception(result);
            }
        }

        public T Post<T, M>(M model) where T : class where M : class
        {
            var requestMessage = new HttpRequestMessage();
            var objectContent = CreateJsonObjectContent(model);
            var responseMessage = _httpClient.PostAsync(addressSuffix, objectContent).Result;
            var result = responseMessage.Content.ReadAsStringAsync().Result;
            if (responseMessage.StatusCode == HttpStatusCode.OK || responseMessage.StatusCode == HttpStatusCode.NoContent)
            {
                if (!string.IsNullOrEmpty(result))
                {
                    return JsonConvert.DeserializeObject<T>(result);
                }
                else
                {
                    return null;
                }
            }
            else
            {
                throw new Exception(result);
            }
        }

        public async Task<T> PostAsync<T, M>(M model) where T : class where M : class
        {
            var requestMessage = new HttpRequestMessage();
            var objectContent = CreateJsonObjectContent(model);
            var responseMessage = await _httpClient.PostAsync(addressSuffix, objectContent);
            var result = await responseMessage.Content.ReadAsStringAsync();
            if (responseMessage.StatusCode == HttpStatusCode.OK || responseMessage.StatusCode == HttpStatusCode.NoContent)
            {

                if (!string.IsNullOrEmpty(result))
                {
                    return JsonConvert.DeserializeObject<T>(result);
                }
                else
                {
                    return null;
                }
            }
            else
            {
                throw new Exception(result);
            }
        }

        public async Task<string> HtmlTemplateAsync<M>(M model) where M : class
        {
            var requestMessage = new HttpRequestMessage();
            var objectContent = CreateJsonObjectContent(model);
            _httpClient.DefaultRequestHeaders.AcceptEncoding.Remove(StringWithQualityHeaderValue.Parse("gzip"));
            _httpClient.DefaultRequestHeaders.AcceptEncoding.Remove(StringWithQualityHeaderValue.Parse("defalte"));
            var responseMessage = await _httpClient.PostAsync(addressSuffix, objectContent);
            responseMessage.EnsureSuccessStatusCode();
            return await responseMessage.Content.ReadAsStringAsync();
        }

        public async Task<string> GetHtmlAsync()
        {
            var requestMessage = new HttpRequestMessage();
            _httpClient.DefaultRequestHeaders.AcceptEncoding.Remove(StringWithQualityHeaderValue.Parse("gzip"));
            _httpClient.DefaultRequestHeaders.AcceptEncoding.Remove(StringWithQualityHeaderValue.Parse("defalte"));
            var responseMessage = await _httpClient.GetAsync(addressSuffix);
            responseMessage.EnsureSuccessStatusCode();
            return await responseMessage.Content.ReadAsStringAsync();

        }

        public async Task<T> CompressedPostAsync<T, M>(M model) where T : class where M : class
        {
            var requestMessage = new HttpRequestMessage();
            var objectContent = CreateCompressedJsonObjectContent(model);
            var responseMessage = await _httpClient.PostAsync(addressSuffix, objectContent);
            responseMessage.EnsureSuccessStatusCode();
            var result = await responseMessage.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<T>(result);
        }

        public async Task PutAsync<T>(T model) where T : class
        {
            var requestMessage = new HttpRequestMessage();
            var objectContent = CreateJsonObjectContent(model);
            var responseMessage = await _httpClient.PutAsync(addressSuffix, objectContent);
            responseMessage.EnsureSuccessStatusCode();
        }

        public async Task DeleteAsync()
        {
            var r = await _httpClient.DeleteAsync(addressSuffix);
        }




        private StreamContent CreateCompressedJsonObjectContent<T>(T model) where T : class
        {
            string json = JsonConvert.SerializeObject(model, new JsonSerializerSettings { ReferenceLoopHandling = ReferenceLoopHandling.Ignore });
            byte[] jsonBytes = Encoding.UTF8.GetBytes(json);
            MemoryStream ms = new MemoryStream();
            using (GZipStream gzip = new GZipStream(ms, CompressionMode.Compress, true))
            {
                gzip.Write(jsonBytes, 0, jsonBytes.Length);
            }
            ms.Position = 0;
            StreamContent content = new StreamContent(ms);
            content.Headers.ContentEncoding.Add("gzip");
            content.Headers.ContentLength = ms.Length;
            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            return content;
        }

        private StringContent CreateJsonObjectContent<T>(T model) where T : class
        {
            string json = JsonConvert.SerializeObject(model, new JsonSerializerSettings { ReferenceLoopHandling = ReferenceLoopHandling.Ignore });
            var stringContent = new StringContent(json);
            stringContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            return stringContent;

        }

        #region IDisposable Members

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (!disposed && disposing)
            {
                if (_httpClient != null)
                {
                    var hc = _httpClient;
                    _httpClient = null;
                    hc.Dispose();
                }
                disposed = true;
            }
        }

        #endregion IDisposable Members

        public void SetRouteMap(string routeName)
        {
            //routeMapDto = AccountingRouteMap.Map.FirstOrDefault(x => x.Name == routeName);
        }

    }
}
