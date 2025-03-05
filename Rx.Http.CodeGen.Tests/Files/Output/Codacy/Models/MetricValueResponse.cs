using Newtonsoft.Json;

namespace Codacy.Models
{
    public class MetricValueResponse
    {
        [JsonProperty("data")]
        public MetricValue Data { get; set; }
    }
}
