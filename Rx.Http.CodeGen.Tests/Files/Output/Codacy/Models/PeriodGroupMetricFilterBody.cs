using Newtonsoft.Json;

namespace Codacy.Models
{
    public class PeriodGroupMetricFilterBody
    {
        [JsonProperty("filter")]
        public MetricFilter Filter { get; set; }
        [JsonProperty("groupBy")]
        public MetricGroupBy GroupBy { get; set; }
        [JsonProperty("date")]
        public string Date { get; set; }
        [JsonProperty("period")]
        public string Period { get; set; }
    }
}
