using Newtonsoft.Json;

namespace Codacy.Models
{
    public class PeriodMetricFilterBody
    {
        [JsonProperty("filter")]
        public MetricFilter Filter { get; set; }
        [JsonProperty("date")]
        public string Date { get; set; }
        [JsonProperty("period")]
        public string Period { get; set; }
    }
}
