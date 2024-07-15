using Newtonsoft.Json;

namespace Codacy.Models
{
    public class Category
    {
        [JsonProperty("categoryType")]
        public string CategoryType { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
    }
}
