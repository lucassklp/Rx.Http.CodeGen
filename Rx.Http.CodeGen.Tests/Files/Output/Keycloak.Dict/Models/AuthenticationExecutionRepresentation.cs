using Newtonsoft.Json;

namespace Keycloak.Dict.Models
{
    public class AuthenticationExecutionRepresentation
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
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("flowId")]
        public string FlowId { get; set; }
        [JsonProperty("parentFlow")]
        public string ParentFlow { get; set; }
    }
}
