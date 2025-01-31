using Newtonsoft.Json;

namespace Codacy.Models
{
    public class MetricGroup
    {
        [JsonProperty("organization")]
        public string Organization { get; set; }
        [JsonProperty("repository")]
        public string Repository { get; set; }
        [JsonProperty("dimensions")]
        public List<string> Dimensions { get; set; }
    }
}
