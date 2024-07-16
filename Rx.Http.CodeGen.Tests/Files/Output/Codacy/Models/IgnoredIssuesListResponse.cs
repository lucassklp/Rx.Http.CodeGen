using Newtonsoft.Json;

namespace Codacy.Models
{
    public class IgnoredIssuesListResponse
    {
        [JsonProperty("data")]
        public List<IgnoredIssue> Data { get; set; }
        [JsonProperty("pagination")]
        public PaginationInfo Pagination { get; set; }
    }
}
