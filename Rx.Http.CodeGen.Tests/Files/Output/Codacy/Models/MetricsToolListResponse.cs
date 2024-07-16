using Newtonsoft.Json;

namespace Codacy.Models
{
    public class MetricsToolListResponse
    {
        [JsonProperty("data")]
        public List<MetricsTool> Data { get; set; }
    }
}
