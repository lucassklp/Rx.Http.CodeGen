using Newtonsoft.Json;

namespace Keycloak.Models
{
    public class PolicyRepresentation
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("policies")]
        public List<string> Policies { get; set; }
        [JsonProperty("resources")]
        public List<string> Resources { get; set; }
        [JsonProperty("scopes")]
        public List<string> Scopes { get; set; }
        [JsonProperty("logic")]
        public Logic Logic { get; set; }
        [JsonProperty("decisionStrategy")]
        public DecisionStrategy DecisionStrategy { get; set; }
        [JsonProperty("owner")]
        public string Owner { get; set; }
        [JsonProperty("resourcesData")]
        public List<ResourceRepresentation> ResourcesData { get; set; }
        [JsonProperty("scopesData")]
        public List<ScopeRepresentation> ScopesData { get; set; }
        [JsonProperty("config")]
        public object Config { get; set; }
    }
}
