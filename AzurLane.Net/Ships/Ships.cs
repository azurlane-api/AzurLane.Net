using System.Collections.Generic;
using System.Threading.Tasks;
using AzurLane.Net.Core;
using Newtonsoft.Json;

namespace AzurLane.Net.Ships
{
    public class Category
    {
        private Category(string value) => Value = value;

        public string Value { get; private set; }
        
        public static Category Rarity => new Category("rarity");
        public static Category Type => new Category("type");
        public static Category Affiliation => new Category("affiliation");
    }
    
    public static class Ships
    {
        /// <summary>
        /// Get a list of ships from rarity, type or affiliation
        /// </summary>
        /// <param name="category">The category</param>
        /// /// <param name="value">Value depends on what order is used, e.g. if `Order.Rarity` is used value can be `Super Rare`</param>
        /// <returns>List of ships</returns>
        /// <exception cref="ErrorResponseException"></exception>
        public static async Task<List<ShipModel>> GetListAsync(Category category, string value)
        {
            var json = await Api.Client.GetStringAsync($"{Api.BaseUrl}/ships?orderBy={category.Value}&{category.Value}={value}");
            var response = JsonConvert.DeserializeObject<ShipsResponseModel>(json);
            if (response.Ships != null)
            {
                return response.Ships;
            }
            var error = JsonConvert.DeserializeObject<ErrorResponse>(json);
            throw new ErrorResponseException(error);
        }
    }
}