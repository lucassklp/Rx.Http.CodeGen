using Newtonsoft.Json;

namespace Codacy.Models
{
    public class PeriodGroupedMetricValuesResponse
    {
        [JsonProperty("data")]
        public List<GroupedMetricValue> Data { get; set; }
    }
}
