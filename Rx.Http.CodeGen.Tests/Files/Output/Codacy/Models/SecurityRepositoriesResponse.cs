using Newtonsoft.Json;

namespace Codacy.Models
{
    public class SecurityRepositoriesResponse
    {
        [JsonProperty("pagination")]
        public PaginationInfo Pagination { get; set; }
        [JsonProperty("data")]
        public List<RepositorySummary> Data { get; set; }
    }
}
