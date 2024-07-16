using Newtonsoft.Json;

namespace Codacy.Models
{
    public class IssuesOverview
    {
        [JsonProperty("counts")]
        public IssuesOverviewCounts Counts { get; set; }
    }
}
