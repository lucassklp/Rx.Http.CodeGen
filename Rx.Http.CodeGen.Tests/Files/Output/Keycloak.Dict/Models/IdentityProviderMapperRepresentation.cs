using Newtonsoft.Json;

namespace Keycloak.Dict.Models
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
        public Dictionary<string, object> Config { get; set; }
    }
}
