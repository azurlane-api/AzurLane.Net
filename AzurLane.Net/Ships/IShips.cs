using System.Collections.Generic;

#nullable enable

namespace AzurLane.Net.Ships
{
    public interface IShip
    {
        string Id { get; }
        string Name { get; }
    }
    
    public interface IShipsResponse
    {
        List<ShipModel>? Ships { get; }
    }
}