using Newtonsoft.Json;

namespace Codacy.Models
{
    public class UpdateGatePolicyBody
    {
        [JsonProperty("gatePolicyName")]
        public string GatePolicyName { get; set; }
        [JsonProperty("isDefault")]
        public bool IsDefault { get; set; }
        [JsonProperty("settings")]
        public QualityGate Settings { get; set; }
    }
}
