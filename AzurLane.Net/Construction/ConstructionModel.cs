using Newtonsoft.Json;

#nullable enable

namespace AzurLane.Net.Construction
{
    public class ConstructionModel : IConstruction
    {
        [JsonProperty("time")]
        public string Time { get; private set; }
        
        [JsonProperty("wikiUrl")]
        public string WikiUrl { get; private set; }
        
        [JsonProperty("ships")]
        public string[] Ships { get; private set; }
    }

    public class ConstructionResponseModel : IConstructionResponse
    {
        [JsonProperty("statusCode")]
        public int StatusCode { get; private set; }
        
        [JsonProperty("statusMessage")]
        public string StatusMessage { get; private set; }
        
        [JsonProperty("message")]
        public string Message { get; private set; }
        
        [JsonProperty("construction")]
        public ConstructionModel? Construction { get; private set; }
    }
}