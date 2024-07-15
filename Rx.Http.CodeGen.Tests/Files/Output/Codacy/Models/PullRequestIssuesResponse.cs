using Newtonsoft.Json;

namespace Codacy.Models
{
    public class PullRequestIssuesResponse
    {
        [JsonProperty("analyzed")]
        public bool Analyzed { get; set; }
        [JsonProperty("data")]
        public List<CommitDeltaIssue> Data { get; set; }
        [JsonProperty("pagination")]
        public PaginationInfo Pagination { get; set; }
    }
}
