using Newtonsoft.Json;

namespace Codacy.Models
{
    public class PatternsCount
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("total")]
        public int Total { get; set; }
    }
}
