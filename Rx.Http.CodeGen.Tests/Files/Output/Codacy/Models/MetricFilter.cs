using Newtonsoft.Json;

namespace Codacy.Models
{
    public class MetricFilter
    {
        [JsonProperty("entityFilter")]
        public EntityFilter EntityFilter { get; set; }
        [JsonProperty("dimensionsFilter")]
        public List<DimensionsFilter> DimensionsFilter { get; set; }
    }
}
