using Newtonsoft.Json;

namespace Codacy.Models
{
    public class GroupMetricFilter
    {
        [JsonProperty("filter")]
        public MetricFilter Filter { get; set; }
        [JsonProperty("groupBy")]
        public MetricGroupBy GroupBy { get; set; }
    }
}
