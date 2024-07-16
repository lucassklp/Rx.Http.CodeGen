using Newtonsoft.Json;

namespace Codacy.Models
{
    public class IntegrationListResponse
    {
        [JsonProperty("pagination")]
        public PaginationInfo Pagination { get; set; }
        [JsonProperty("data")]
        public List<Integration> Data { get; set; }
    }
}
