using Newtonsoft.Json;

namespace Codacy.Models
{
    public class TimerangeMetricValue
    {
        [JsonProperty("date")]
        public string Date { get; set; }
        [JsonProperty("group")]
        public MetricGroup Group { get; set; }
        [JsonProperty("value")]
        public double Value { get; set; }
    }
}
