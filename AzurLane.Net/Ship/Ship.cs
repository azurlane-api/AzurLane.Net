using System.Threading.Tasks;
using AzurLane.Net.Core;
using Newtonsoft.Json;

namespace AzurLane.Net.Ship
{
    public static class Ship
    {
        /// <summary>
        /// Get info about a ship
        /// </summary>
        /// <param name="name">Ship name</param>
        /// <returns>All ship info</returns>
        /// <exception cref="ErrorResponseException"></exception>
        public static async Task<ShipModel> GetByNameAsync(string name)
        {
            var json = await Api.Client.GetStringAsync($"{Api.BaseUrl}/ship?name={name}");
            var response = JsonConvert.DeserializeObject<ShipResponseModel>(json);
            if (response.Ship != null) return response.Ship;
            var error = JsonConvert.DeserializeObject<ErrorResponse>(json);
            throw new ErrorResponseException(error);
        }
        
        /// <summary>
        /// Get info about a ship
        /// </summary>
        /// <param name="id">Ship id</param>
        /// <returns>All ship info</returns>
        /// <exception cref="ErrorResponseException"></exception>
        public static async Task<ShipModel> GetByIdAsync(string id)
        {
            var json = await Api.Client.GetStringAsync($"{Api.BaseUrl}/ship?id={id}");
            var response = JsonConvert.DeserializeObject<ShipResponseModel>(json);
            if (response.Ship != null) return response.Ship;
            var error = JsonConvert.DeserializeObject<ErrorResponse>(json);
            throw new ErrorResponseException(error);
        }
    }
}