using Newtonsoft.Json;

namespace Keycloak.Models
{
    public class PolicyEnforcerConfig
    {
        [JsonProperty("enforcement-mode")]
        public EnforcementMode EnforcementMode { get; set; }
        [JsonProperty("paths")]
        public List<PathConfig> Paths { get; set; }
        [JsonProperty("path-cache")]
        public PathCacheConfig PathCache { get; set; }
        [JsonProperty("lazy-load-paths")]
        public bool LazyLoadPaths { get; set; }
        [JsonProperty("on-deny-redirect-to")]
        public string OnDenyRedirectTo { get; set; }
        [JsonProperty("user-managed-access")]
        public object UserManagedAccess { get; set; }
        [JsonProperty("claim-information-point")]
        public object ClaimInformationPoint { get; set; }
        [JsonProperty("http-method-as-scope")]
        public bool HttpMethodAsScope { get; set; }
        [JsonProperty("realm")]
        public string Realm { get; set; }
        [JsonProperty("auth-server-url")]
        public string AuthServerUrl { get; set; }
        [JsonProperty("credentials")]
        public object Credentials { get; set; }
        [JsonProperty("resource")]
        public string Resource { get; set; }
    }
}
