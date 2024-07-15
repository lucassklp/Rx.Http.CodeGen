using Newtonsoft.Json;

namespace Keycloak.Models
{
    public class ResourceServerRepresentation
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("clientId")]
        public string ClientId { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("allowRemoteResourceManagement")]
        public bool AllowRemoteResourceManagement { get; set; }
        [JsonProperty("policyEnforcementMode")]
        public PolicyEnforcementMode PolicyEnforcementMode { get; set; }
        [JsonProperty("resources")]
        public List<ResourceRepresentation> Resources { get; set; }
        [JsonProperty("policies")]
        public List<PolicyRepresentation> Policies { get; set; }
        [JsonProperty("scopes")]
        public List<ScopeRepresentation> Scopes { get; set; }
        [JsonProperty("decisionStrategy")]
        public DecisionStrategy DecisionStrategy { get; set; }
    }
}
