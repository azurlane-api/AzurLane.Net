using System.Net.Http;
using System.Net.Http.Headers;
// ReSharper disable ConvertToConstant.Global
// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable ClassNeverInstantiated.Global

namespace AzurLane.Net
{
    public class Options
    {
        public readonly string UserAgent;
        public readonly string Token;
        public Options(string token, string userAgent = null)
        {
            UserAgent = userAgent ?? Api.DefaultUserAgent;
            Token = token;
        }
    }
    
    public class Api
    {
        public static readonly string Version = "1.2.0";
        internal static readonly string DefaultUserAgent = $"AzurLane.Net/v{Version} (https://github.com/azurlane-api/AzurLane.Net)";
        internal const string BaseUrl = "https://azurlane-api.herokuapp.com/v2";

        public static string UserAgent;
        public static string Token;
        public Api(Options options)
        {
            UserAgent = options.UserAgent;
            Token = options.Token;
        }

        private static HttpClient RequestClient()
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Add("User-Agent", UserAgent);
            client.DefaultRequestHeaders.Add("Authorization", Token);
            return client;
        }

        internal static readonly HttpClient Client = RequestClient();
    }
}
