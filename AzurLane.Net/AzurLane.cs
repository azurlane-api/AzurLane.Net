using System.Net.Http;
using System.Net.Http.Headers;
// ReSharper disable ConvertToConstant.Global
// ReSharper disable MemberCanBePrivate.Global

namespace AzurLane.Net
{
    public static class Api
    {
        public static readonly string Version = "1.0.0";
        private static readonly string UserAgent = $"AzurLane.Net/v{Version} (https://github.com/KurozeroPB/AzurLane.Net)";

        internal const string BaseUrl = "https://azurlane-api.appspot.com/v1";

        private static HttpClient RequestClient()
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Add("User-Agent", UserAgent);
            return client;
        }

        internal static readonly HttpClient Client = RequestClient();
    }
}