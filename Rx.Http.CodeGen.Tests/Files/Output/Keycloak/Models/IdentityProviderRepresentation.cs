using Newtonsoft.Json;

namespace Keycloak.Models
{
    public class IdentityProviderRepresentation
    {
        [JsonProperty("alias")]
        public string Alias { get; set; }
        [JsonProperty("displayName")]
        public string DisplayName { get; set; }
        [JsonProperty("internalId")]
        public string InternalId { get; set; }
        [JsonProperty("providerId")]
        public string ProviderId { get; set; }
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }
        [JsonProperty("updateProfileFirstLoginMode")]
        public string UpdateProfileFirstLoginMode { get; set; }
        [JsonProperty("trustEmail")]
        public bool TrustEmail { get; set; }
        [JsonProperty("storeToken")]
        public bool StoreToken { get; set; }
        [JsonProperty("addReadTokenRoleOnCreate")]
        public bool AddReadTokenRoleOnCreate { get; set; }
        [JsonProperty("authenticateByDefault")]
        public bool AuthenticateByDefault { get; set; }
        [JsonProperty("linkOnly")]
        public bool LinkOnly { get; set; }
        [JsonProperty("firstBrokerLoginFlowAlias")]
        public string FirstBrokerLoginFlowAlias { get; set; }
        [JsonProperty("postBrokerLoginFlowAlias")]
        public string PostBrokerLoginFlowAlias { get; set; }
        [JsonProperty("config")]
        public object Config { get; set; }
        [JsonProperty("updateProfileFirstLogin")]
        public bool UpdateProfileFirstLogin { get; set; }
    }
}
