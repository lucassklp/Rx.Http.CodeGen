using Newtonsoft.Json;

namespace Keycloak.Models
{
    public class PathConfig
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("path")]
        public string Path { get; set; }
        [JsonProperty("methods")]
        public List<MethodConfig> Methods { get; set; }
        [JsonProperty("scopes")]
        public List<string> Scopes { get; set; }
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("enforcement-mode")]
        public EnforcementMode EnforcementMode { get; set; }
        [JsonProperty("claim-information-point")]
        public object ClaimInformationPoint { get; set; }
        [JsonProperty("invalidated")]
        public bool Invalidated { get; set; }
        [JsonProperty("staticPath")]
        public bool StaticPath { get; set; }
        [JsonProperty("static")]
        public bool Static { get; set; }
    }
}
