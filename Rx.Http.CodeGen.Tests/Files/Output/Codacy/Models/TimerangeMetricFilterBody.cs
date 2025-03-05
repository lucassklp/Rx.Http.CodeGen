using Newtonsoft.Json;

namespace Codacy.Models
{
    public class TimerangeMetricFilterBody
    {
        [JsonProperty("filter")]
        public MetricFilter Filter { get; set; }
        [JsonProperty("groupBy")]
        public MetricGroupBy GroupBy { get; set; }
        [JsonProperty("from")]
        public string From { get; set; }
        [JsonProperty("to")]
        public string To { get; set; }
    }
}
