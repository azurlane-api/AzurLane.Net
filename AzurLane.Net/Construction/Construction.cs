using System.Threading.Tasks;
using AzurLane.Net.Core;
using Newtonsoft.Json;

namespace AzurLane.Net.Construction
{
    public static class Construction
    {
        /// <summary>
        /// Get a list of ships with the same construction time
        /// </summary>
        /// <param name="time">The construction time</param>
        /// <returns>List of ships</returns>
        /// <exception cref="ErrorResponseException"></exception>
        public static async Task<ConstructionModel> GetInfoAsync(string time)
        {
            var json = await Api.Client.GetStringAsync($"{Api.BaseUrl}/build?time={time}");
            var response = JsonConvert.DeserializeObject<ConstructionResponseModel>(json);
            if (response.Construction != null) return response.Construction;
            var error = JsonConvert.DeserializeObject<ErrorResponse>(json);
            throw new ErrorResponseException(error);
        }
    }
}