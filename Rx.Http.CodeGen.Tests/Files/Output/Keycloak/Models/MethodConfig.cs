using Newtonsoft.Json;

namespace Keycloak.Models
{
    public class MethodConfig
    {
        [JsonProperty("method")]
        public string Method { get; set; }
        [JsonProperty("scopes")]
        public List<string> Scopes { get; set; }
        [JsonProperty("scopes-enforcement-mode")]
        public ScopeEnforcementMode ScopesEnforcementMode { get; set; }
    }
}
