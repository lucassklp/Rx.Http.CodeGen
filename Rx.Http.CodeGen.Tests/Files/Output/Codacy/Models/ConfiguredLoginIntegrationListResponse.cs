using Newtonsoft.Json;

namespace Codacy.Models
{
    public class ConfiguredLoginIntegrationListResponse
    {
        [JsonProperty("pagination")]
        public PaginationInfo Pagination { get; set; }
        [JsonProperty("data")]
        public List<ConfiguredLoginIntegration> Data { get; set; }
    }
}
