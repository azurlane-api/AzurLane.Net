using Newtonsoft.Json;

#nullable enable

namespace AzurLane.Net.Core
{
    public class ErrorResponse : IErrorResponse
    {
        [JsonProperty("statusCode")]
        public int StatusCode { get; private set; }
        
        [JsonProperty("statusMessage")]
        public string StatusMessage { get; private set; }
        
        [JsonProperty("message")]
        public string Message { get; private set; }
        
        [JsonProperty("error")]
        public string? Error { get; private set; }
    }
}