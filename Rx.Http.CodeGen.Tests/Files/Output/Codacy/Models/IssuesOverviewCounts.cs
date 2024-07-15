using Newtonsoft.Json;

namespace Codacy.Models
{
    public class IssuesOverviewCounts
    {
        [JsonProperty("categories")]
        public List<Count> Categories { get; set; }
        [JsonProperty("languages")]
        public List<Count> Languages { get; set; }
        [JsonProperty("levels")]
        public List<Count> Levels { get; set; }
        [JsonProperty("patterns")]
        public List<PatternsCount> Patterns { get; set; }
        [JsonProperty("authors")]
        public List<Count> Authors { get; set; }
    }
}
