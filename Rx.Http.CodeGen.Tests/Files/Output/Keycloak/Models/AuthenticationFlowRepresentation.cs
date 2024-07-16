using Newtonsoft.Json;

namespace Keycloak.Models
{
    public class AuthenticationFlowRepresentation
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("alias")]
        public string Alias { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("providerId")]
        public string ProviderId { get; set; }
        [JsonProperty("topLevel")]
        public bool TopLevel { get; set; }
        [JsonProperty("builtIn")]
        public bool BuiltIn { get; set; }
        [JsonProperty("authenticationExecutions")]
        public List<AuthenticationExecutionExportRepresentation> AuthenticationExecutions { get; set; }
    }
}
