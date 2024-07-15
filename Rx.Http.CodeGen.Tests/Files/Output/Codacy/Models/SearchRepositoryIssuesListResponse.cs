using Newtonsoft.Json;

namespace Codacy.Models
{
    public class SearchRepositoryIssuesListResponse
    {
        [JsonProperty("data")]
        public List<CommitIssue> Data { get; set; }
        [JsonProperty("pagination")]
        public PaginationInfo Pagination { get; set; }
    }
}
