using Newtonsoft.Json;

namespace Codacy.Models
{
    public class SecurityManagersResponse
    {
        [JsonProperty("pagination")]
        public PaginationInfo Pagination { get; set; }
        [JsonProperty("data")]
        public List<SecurityManager> Data { get; set; }
    }
}
