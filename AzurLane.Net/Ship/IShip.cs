using System.Collections.Generic;
using AzurLane.Net.Core;

#nullable enable

namespace AzurLane.Net.Ship
{
    public interface INames
    {
        string? En { get; }
        string? Cn { get; }
        string? Jp { get; }
        string? Kr { get; }
    }

    public interface ISkinData
    {
        string? Title { get; }
        string? Image { get; }
        string? Chibi { get; }
    }

    public interface IStars
    {
        string? Value { get; }
        int Count { get; }
    }

    public interface IStatData
    {
        string? Name { get; }
        string? Image { get; }
        string? Value { get; }
    }

    public interface IStats
    {
        List<StatDataModel>? Hundred { get; }
        List<StatDataModel>? HundredTwenty { get; }
        List<StatDataModel>? Base { get; }
        List<StatDataModel>? RetrofitHundred { get; }
        List<StatDataModel>? RetrofitHundredTwenty { get; }
    }

    public interface IMiscellaneousData
    {
        string? Link { get; }
        string? Name { get; }
    }

    public interface IMiscellaneous
    {
        MiscellaneousDataModel? Artist { get; }
        MiscellaneousDataModel? Web { get; }
        MiscellaneousDataModel? Pixiv { get; }
        MiscellaneousDataModel? Twitter { get; }
        MiscellaneousDataModel? VoiceActress { get; }
    }

    public interface IShip
    {
        string WikiUrl  { get; }
        string? Id  { get; }
        NamesModel Names { get; }
        string Thumbnail { get; }
        List<SkinDataModel> Skins { get; }
        string? BuildTime { get; }
        string Rarity { get; }
        StarsModel Stars { get; }
        string? Class { get; }
        string? Nationality { get; }
        string? NationalityShort { get; }
        string? HullType { get; }
        StatsModel Stats { get; }
        MiscellaneousModel Miscellaneous { get; }
    }

    public interface IShipResponse : IBaseResponse
    {
        ShipModel? Ship { get; }
    }
}