using Newtonsoft.Json;

namespace Codacy.Models
{
    public class CommitAnalysisStatsListResponse
    {
        [JsonProperty("data")]
        public List<CommitAnalysisStats> Data { get; set; }
    }
}
