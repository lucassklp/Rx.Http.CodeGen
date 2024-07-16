using Newtonsoft.Json;

namespace Codacy.Models
{
    public class MetricsTool
    {
        [JsonProperty("dockerImage")]
        public string DockerImage { get; set; }
        [JsonProperty("languages")]
        public List<string> Languages { get; set; }
    }
}
