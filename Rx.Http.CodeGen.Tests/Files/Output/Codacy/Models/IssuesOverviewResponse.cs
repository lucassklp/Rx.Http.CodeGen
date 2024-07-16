using Newtonsoft.Json;

namespace Codacy.Models
{
    public class IssuesOverviewResponse
    {
        [JsonProperty("data")]
        public IssuesOverview Data { get; set; }
    }
}
