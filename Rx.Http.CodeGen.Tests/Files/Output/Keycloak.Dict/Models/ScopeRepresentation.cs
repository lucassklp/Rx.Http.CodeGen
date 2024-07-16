using Newtonsoft.Json;

namespace Keycloak.Dict.Models
{
    public class ScopeRepresentation
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("iconUri")]
        public string IconUri { get; set; }
        [JsonProperty("policies")]
        public List<PolicyRepresentation> Policies { get; set; }
        [JsonProperty("resources")]
        public List<ResourceRepresentation> Resources { get; set; }
        [JsonProperty("displayName")]
        public string DisplayName { get; set; }
    }
}
