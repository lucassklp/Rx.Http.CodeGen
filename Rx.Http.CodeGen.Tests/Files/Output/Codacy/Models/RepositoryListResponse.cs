using Newtonsoft.Json;

namespace Codacy.Models
{
    public class RepositoryListResponse
    {
        [JsonProperty("pagination")]
        public PaginationInfo Pagination { get; set; }
        [JsonProperty("data")]
        public List<Repository> Data { get; set; }
    }
}
