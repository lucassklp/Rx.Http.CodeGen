using Newtonsoft.Json;

namespace Codacy.Models
{
    public class Pattern
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
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("explanation")]
        public string Explanation { get; set; }
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }
        [JsonProperty("languages")]
        public List<string> Languages { get; set; }
        [JsonProperty("timeToFix")]
        public int TimeToFix { get; set; }
        [JsonProperty("parameters")]
        public List<Parameter> Parameters { get; set; }
    }
}
