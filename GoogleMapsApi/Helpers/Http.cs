using System;
using System.IO;
using System.Net;
using Newtonsoft.Json;

namespace GoogleMapsApi
{
    internal static class Http
    {
        public class HttpGetResponse
        {
            private Uri requestUri;

            public HttpGetResponse(Uri uri)
            {
                requestUri = uri;
            }

            public string AsString()
            {
                var output = String.Empty;

                var response = WebRequest.Create(requestUri).GetResponse();
                using (var reader = new StreamReader(response.GetResponseStream()))
                {
                    output = reader.ReadToEnd();
                    reader.Close();
                }
                response.Close();

                return output;
            }

            public T As<T>() where T : class
            {
                return JsonConvert.DeserializeObject<T>(AsString());
            }
        }

        public static HttpGetResponse Get(Uri uri)
        {
            return new HttpGetResponse(uri);
        }

        public static string UrlEncoding(string str)
        {
            return str
                .Replace("%", "%25")
                .Replace(" ", "%20")
                .Replace("!", "%21")
                .Replace("\"", "%22")
                .Replace("#", "%23")
                .Replace("$", "%24")
                .Replace("&", "%26")
                .Replace("'", "%27")
                .Replace("(", "%28")
                .Replace(")", "%29")
                .Replace("*", "%2A")
                .Replace("+", "%2B")
                .Replace(",", "%2C")
                .Replace("-", "%2D")
                .Replace(".", "%2E")
                .Replace("/", "%2F")
                .Replace(":", "%3A")
                .Replace(";", "%3B")
                .Replace("<", "%3C")
                .Replace("=", "%3D")
                .Replace(">", "%3E")
                .Replace("?", "%3F")
                .Replace("@", "%40")
                .Replace("[", "%5B")
                .Replace("\\", "%5C")
                .Replace("]", "%5D")
                .Replace("^", "%5E")
                .Replace("_", "%5F")
                .Replace("`", "%60")
                .Replace("{", "%7B")
                .Replace("|", "%7C")
                .Replace("}", "%7D")
                .Replace("~", "%7E");
        }
    }
}