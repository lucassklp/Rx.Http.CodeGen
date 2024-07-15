using Newtonsoft.Json;

namespace Keycloak.Dict.Models
{
    public class IdentityProviderMapperTypeRepresentation
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("category")]
        public string Category { get; set; }
        [JsonProperty("helpText")]
        public string HelpText { get; set; }
        [JsonProperty("properties")]
        public List<ConfigPropertyRepresentation> Properties { get; set; }
    }
}
