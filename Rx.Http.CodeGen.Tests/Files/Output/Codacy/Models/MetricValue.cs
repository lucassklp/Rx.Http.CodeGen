using Newtonsoft.Json;

namespace Codacy.Models
{
    public class MetricValue
    {
        [JsonProperty("value")]
        public double Value { get; set; }
    }
}
