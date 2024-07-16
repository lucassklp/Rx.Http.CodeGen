using Newtonsoft.Json;

namespace Codacy.Models
{
    public class FirstAnalysisOverviewResponse
    {
        [JsonProperty("data")]
        public List<FirstAnalysisOverview> Data { get; set; }
    }
}
