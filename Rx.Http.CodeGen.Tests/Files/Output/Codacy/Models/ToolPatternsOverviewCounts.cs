using Newtonsoft.Json;

namespace Codacy.Models
{
    public class ToolPatternsOverviewCounts
    {
        [JsonProperty("languages")]
        public List<Count> Languages { get; set; }
        [JsonProperty("categories")]
        public List<Count> Categories { get; set; }
        [JsonProperty("severities")]
        public List<Count> Severities { get; set; }
        [JsonProperty("totalRecommended")]
        public int TotalRecommended { get; set; }
        [JsonProperty("totalEnabled")]
        public int TotalEnabled { get; set; }
    }
}
