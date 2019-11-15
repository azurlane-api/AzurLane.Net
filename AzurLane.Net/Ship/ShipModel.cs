using System.Collections.Generic;
using Newtonsoft.Json;

#nullable enable

namespace AzurLane.Net.Ship
{
    public class NamesModel : INames
    {
        [JsonProperty("en")]
        public string? En { get; private set; }
        
        [JsonProperty("cn")]
        public string? Cn { get; private set; }
        
        [JsonProperty("jp")]
        public string? Jp { get; private set; }
        
        [JsonProperty("kr")]
        public string? Kr { get; private set; }
    }

    public class SkinDataModel : ISkinData
    {
        [JsonProperty("title")]
        public string? Title { get; private set; }
        
        [JsonProperty("image")]
        public string? Image { get; private set; }
        
        [JsonProperty("chibi")]
        public string? Chibi { get; private set; }
    }

    public class StarsModel : IStars
    {
        [JsonProperty("value")]
        public string? Value { get; private set; }
        
        [JsonProperty("count")]
        public int Count { get; private set; }
    }

    public class StatDataModel : IStatData
    {
        [JsonProperty("name")]
        public string? Name { get; private set; }
        
        [JsonProperty("image")]
        public string? Image { get; private set; }
        
        [JsonProperty("value")]
        public string? Value { get; private set; }
    }

    public class StatsModel : IStats
    {
        [JsonProperty("level100")]
        public List<StatDataModel>? Level100 { get; private set; }
        
        [JsonProperty("level120")]
        public List<StatDataModel>? Level120 { get; private set; }
        
        [JsonProperty("base")]
        public List<StatDataModel>? Base { get; private set; }
        
        [JsonProperty("retrofit100")]
        public List<StatDataModel>? RetrofitHundred { get; private set; }
        
        [JsonProperty("retrofit120")]
        public List<StatDataModel>? RetrofitHundredTwenty { get; private set; }
    }

    public class MiscellaneousDataModel : IMiscellaneousData
    {
        [JsonProperty("link")]
        public string? Link { get; private set; }
        
        [JsonProperty("name")]
        public string? Name { get; private set; }
    }

    public class MiscellaneousModel : IMiscellaneous
    {
        [JsonProperty("artist")]
        public MiscellaneousDataModel? Artist { get; private set; }
        
        [JsonProperty("web")]
        public MiscellaneousDataModel? Web { get; private set; }
        
        [JsonProperty("pixiv")]
        public MiscellaneousDataModel? Pixiv { get; private set; }
        
        [JsonProperty("twitter")]
        public MiscellaneousDataModel? Twitter { get; private set; }
        
        [JsonProperty("voiceActress")]
        public MiscellaneousDataModel? VoiceActress { get; private set; }
    }

    public class ShipModel : IShip
    {
        [JsonProperty("wikiUrl")]
        public string WikiUrl  { get; private set; }
        
        [JsonProperty("id")]
        public string? Id  { get; private set; }
        
        [JsonProperty("names")]
        public NamesModel Names { get; private set; }
        
        [JsonProperty("thumbnail")]
        public string Thumbnail { get; private set; }
        
        [JsonProperty("skins")]
        public List<SkinDataModel> Skins { get; private set; }
        
        [JsonProperty("buildTime")]
        public string? BuildTime { get; private set; }
        
        [JsonProperty("rarity")]
        public string Rarity { get; private set; }
        
        [JsonProperty("stars")]
        public StarsModel Stars { get; private set; }
        
        [JsonProperty("class")]
        public string? Class { get; private set; }
        
        [JsonProperty("nationality")]
        public string? Nationality { get; private set; }
        
        [JsonProperty("nationalityShort")]
        public string? NationalityShort { get; private set; }
        
        [JsonProperty("hullType")]
        public string? HullType { get; private set; }
        
        [JsonProperty("stats")]
        public StatsModel Stats { get; private set; }
        
        [JsonProperty("miscellaneous")]
        public MiscellaneousModel Miscellaneous { get; private set; }
    }

    public class ShipResponseModel : IShipResponse
    {
        [JsonProperty("statusCode")]
        public int StatusCode { get; private set; }
        
        [JsonProperty("statusMessage")]
        public string StatusMessage { get; private set; }
        
        [JsonProperty("message")]
        public string Message { get; private set; }
        
        [JsonProperty("ship")]
        public ShipModel? Ship { get; private set; }
    }
}