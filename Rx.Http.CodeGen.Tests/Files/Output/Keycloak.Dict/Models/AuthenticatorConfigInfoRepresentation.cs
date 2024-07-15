using Newtonsoft.Json;

namespace Keycloak.Dict.Models
{
    public class AuthenticatorConfigInfoRepresentation
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("providerId")]
        public string ProviderId { get; set; }
        [JsonProperty("helpText")]
        public string HelpText { get; set; }
        [JsonProperty("properties")]
        public List<ConfigPropertyRepresentation> Properties { get; set; }
    }
}
