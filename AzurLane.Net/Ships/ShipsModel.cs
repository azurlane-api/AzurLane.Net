using System.Collections.Generic;
using Newtonsoft.Json;

#nullable enable

namespace AzurLane.Net.Ships
{
    public class ShipModel : IShip
    {
        [JsonProperty("id")]
        public string Id { get; private set; }
        
        [JsonProperty("name")]
        public string Name { get; private set; }
    }
    
    public class ShipsResponseModel : IShipsResponse
    {
        [JsonProperty("statusCode")]
        public int StatusCode { get; private set; }
        
        [JsonProperty("statusMessage")]
        public string StatusMessage { get; private set; }
        
        [JsonProperty("message")]
        public string Message { get; private set; }
        
        [JsonProperty("ships")]
        public List<ShipModel>? Ships { get; private set; }
    }
}