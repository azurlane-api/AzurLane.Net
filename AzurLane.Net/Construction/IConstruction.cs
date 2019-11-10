#nullable enable

namespace AzurLane.Net.Construction
{
    public interface IConstruction
    {
        string Time { get; }
        string WikiUrl { get; }
        string[] Ships { get; }
    }

    public interface IConstructionResponse
    {
        ConstructionModel? Construction { get; }
    }
}