using Newtonsoft.Json;

namespace Codacy.Models
{
    public class PatternDetails
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("category")]
        public string Category { get; set; }
        [JsonProperty("subCategory")]
        public string SubCategory { get; set; }
        [JsonProperty("level")]
        public string Level { get; set; }
        [JsonProperty("severityLevel")]
        public string SeverityLevel { get; set; }
    }
}
