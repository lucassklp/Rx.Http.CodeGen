using Newtonsoft.Json;

namespace Codacy.Models
{
    public class ApiTokenListResponse
    {
        [JsonProperty("pagination")]
        public PaginationInfo Pagination { get; set; }
        [JsonProperty("data")]
        public List<ApiToken> Data { get; set; }
    }
}
