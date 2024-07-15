using Newtonsoft.Json;

namespace Swagger.Petstore.Models
{
    public class Pet
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("category")]
        public Category Category { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("photoUrls")]
        public List<string> PhotoUrls { get; set; }
        [JsonProperty("tags")]
        public List<Tag> Tags { get; set; }
        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
