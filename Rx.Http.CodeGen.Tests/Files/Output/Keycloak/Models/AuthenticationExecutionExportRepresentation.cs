using Newtonsoft.Json;

namespace Keycloak.Models
{
    public class AuthenticationExecutionExportRepresentation
    {
        [JsonProperty("authenticatorConfig")]
        public string AuthenticatorConfig { get; set; }
        [JsonProperty("authenticator")]
        public string Authenticator { get; set; }
        [JsonProperty("authenticatorFlow")]
        public bool AuthenticatorFlow { get; set; }
        [JsonProperty("requirement")]
        public string Requirement { get; set; }
        [JsonProperty("priority")]
        public int Priority { get; set; }
        [JsonProperty("autheticatorFlow")]
        public bool AutheticatorFlow { get; set; }
        [JsonProperty("flowAlias")]
        public string FlowAlias { get; set; }
        [JsonProperty("userSetupAllowed")]
        public bool UserSetupAllowed { get; set; }
    }
}
