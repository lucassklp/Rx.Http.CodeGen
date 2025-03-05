using Newtonsoft.Json;

namespace Codacy.Models
{
    public class ToolPatternsOverview
    {
        [JsonProperty("counts")]
        public ToolPatternsOverviewCounts Counts { get; set; }
    }
}
