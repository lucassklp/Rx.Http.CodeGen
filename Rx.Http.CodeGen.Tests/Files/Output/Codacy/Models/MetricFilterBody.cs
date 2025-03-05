using Newtonsoft.Json;

namespace Codacy.Models
{
    public class MetricFilterBody
    {
        [JsonProperty("data")]
        public MetricFilter Data { get; set; }
    }
}
