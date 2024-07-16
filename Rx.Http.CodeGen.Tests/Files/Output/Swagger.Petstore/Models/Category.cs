using Newtonsoft.Json;

namespace Swagger.Petstore.Models
{
    public class Category
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
