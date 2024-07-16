using Newtonsoft.Json;

namespace Codacy.Models
{
    public class PullRequestWithAnalysisListResponse
    {
        [JsonProperty("data")]
        public List<PullRequestWithAnalysis> Data { get; set; }
        [JsonProperty("pagination")]
        public PaginationInfo Pagination { get; set; }
    }
}
