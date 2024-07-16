using Newtonsoft.Json;

namespace Keycloak.Models
{
    public class IdentityProviderMapperRepresentation
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("identityProviderAlias")]
        public string IdentityProviderAlias { get; set; }
        [JsonProperty("identityProviderMapper")]
        public string IdentityProviderMapper { get; set; }
        [JsonProperty("config")]
        public object Config { get; set; }
    }
}
