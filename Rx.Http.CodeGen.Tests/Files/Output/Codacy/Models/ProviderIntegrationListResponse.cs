using Newtonsoft.Json;

namespace Codacy.Models
{
    public class ProviderIntegrationListResponse
    {
        [JsonProperty("pagination")]
        public PaginationInfo Pagination { get; set; }
        [JsonProperty("data")]
        public List<ProviderIntegration> Data { get; set; }
    }
}
