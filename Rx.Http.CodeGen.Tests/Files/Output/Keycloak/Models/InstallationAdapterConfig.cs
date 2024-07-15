using Newtonsoft.Json;

namespace Keycloak.Models
{
    public class InstallationAdapterConfig
    {
        [JsonProperty("realm")]
        public string Realm { get; set; }
        [JsonProperty("realm-public-key")]
        public string RealmPublicKey { get; set; }
        [JsonProperty("auth-server-url")]
        public string AuthServerUrl { get; set; }
        [JsonProperty("ssl-required")]
        public string SslRequired { get; set; }
        [JsonProperty("bearer-only")]
        public bool BearerOnly { get; set; }
        [JsonProperty("resource")]
        public string Resource { get; set; }
        [JsonProperty("public-client")]
        public bool PublicClient { get; set; }
        [JsonProperty("verify-token-audience")]
        public bool VerifyTokenAudience { get; set; }
        [JsonProperty("credentials")]
        public object Credentials { get; set; }
        [JsonProperty("use-resource-role-mappings")]
        public bool UseResourceRoleMappings { get; set; }
        [JsonProperty("confidential-port")]
        public int ConfidentialPort { get; set; }
        [JsonProperty("policy-enforcer")]
        public PolicyEnforcerConfig PolicyEnforcer { get; set; }
    }
}
