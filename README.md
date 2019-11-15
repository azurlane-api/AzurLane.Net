[![Build status](https://ci.appveyor.com/api/projects/status/2ot3sf9evxcpdc8s?svg=true)](https://ci.appveyor.com/project/KurozeroPB/AzurLane.Net)
[![Codacy Badge](https://api.codacy.com/project/badge/Grade/1645ed68feae48808d9d3a81f3557e36)](https://www.codacy.com/manual/KurozeroPB/AzurLane.Net?utm_source=github.com&amp;utm_medium=referral&amp;utm_content=KurozeroPB/AzurLane.Net&amp;utm_campaign=Badge_Grade)
[![NuGet](https://img.shields.io/nuget/vpre/AzurLane.Net.svg)](https://www.nuget.org/packages/AzurLane.Net)

# AzurLane.Net
.Net wrapper for the unofficial azur lane api

## Example
```cs
using System;
using System.Threading.Tasks;
using AzurLane.Net;
using AzurLane.Net.Ships;

namespace Example
{
    public class Program
    {
        public async Task Main()
        {
            try
            {
                var ships = await Ships.GetListAsync(Category.Rarity, "Super Rare");
                foreach (var ship in ships)
                {
                    Console.WriteLine($"[{ship.Id}]: ({ship.Name})");
                }
            }
            catch (ErrorResponseException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
```

## Support
![discord](https://discordapp.com/api/v6/guilds/240059867744698368/widget.png?style=banner2)
