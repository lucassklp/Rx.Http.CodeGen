using Newtonsoft.Json;

namespace Codacy.Models
{
    public class CommitWithAnalysisListResponse
    {
        [JsonProperty("pagination")]
        public PaginationInfo Pagination { get; set; }
        [JsonProperty("data")]
        public List<CommitWithAnalysis> Data { get; set; }
    }
}
