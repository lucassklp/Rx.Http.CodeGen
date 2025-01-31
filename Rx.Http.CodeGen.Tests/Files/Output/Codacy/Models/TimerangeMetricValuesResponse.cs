using Newtonsoft.Json;

namespace Codacy.Models
{
    public class TimerangeMetricValuesResponse
    {
        [JsonProperty("data")]
        public List<TimerangeMetricValue> Data { get; set; }
    }
}
