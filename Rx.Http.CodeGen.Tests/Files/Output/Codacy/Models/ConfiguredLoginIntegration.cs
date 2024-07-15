using Newtonsoft.Json;

namespace Codacy.Models
{
    public class ConfiguredLoginIntegration
    {
        [JsonProperty("provider")]
        public string Provider { get; set; }
        [JsonProperty("loginUrl")]
        public string LoginUrl { get; set; }
    }
}
