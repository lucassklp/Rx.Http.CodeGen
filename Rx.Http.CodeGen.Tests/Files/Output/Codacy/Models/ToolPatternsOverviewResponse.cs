using Newtonsoft.Json;

namespace Codacy.Models
{
    public class ToolPatternsOverviewResponse
    {
        [JsonProperty("data")]
        public ToolPatternsOverview Data { get; set; }
    }
}
