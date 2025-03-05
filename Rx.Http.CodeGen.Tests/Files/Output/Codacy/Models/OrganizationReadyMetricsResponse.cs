using Newtonsoft.Json;

namespace Codacy.Models
{
    public class OrganizationReadyMetricsResponse
    {
        [JsonProperty("data")]
        public OrganizationReadyMetrics Data { get; set; }
    }
}
