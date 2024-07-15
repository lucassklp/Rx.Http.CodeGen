using Newtonsoft.Json;

namespace Codacy.Models
{
    public class RepositoryWithAnalysisListResponse
    {
        [JsonProperty("pagination")]
        public PaginationInfo Pagination { get; set; }
        [JsonProperty("data")]
        public List<RepositoryWithAnalysis> Data { get; set; }
    }
}
