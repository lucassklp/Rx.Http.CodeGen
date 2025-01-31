using Newtonsoft.Json;

namespace Codacy.Models
{
    public class GroupedMetricValue
    {
        [JsonProperty("group")]
        public MetricGroup Group { get; set; }
        [JsonProperty("value")]
        public double Value { get; set; }
    }
}
