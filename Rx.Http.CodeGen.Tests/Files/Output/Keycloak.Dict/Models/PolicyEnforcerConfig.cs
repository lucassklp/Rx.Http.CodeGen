namespace Keycloak.Dict.Models
{
    public class PolicyEnforcerConfig
    {
        public EnforcementMode EnforcementMode { get; set; }
        public List<PathConfig> Paths { get; set; }
        public PathCacheConfig PathCache { get; set; }
        public bool LazyLoadPaths { get; set; }
        public string OnDenyRedirectTo { get; set; }
        public Dictionary<string, object> UserManagedAccess { get; set; }
        public Dictionary<string, object> ClaimInformationPoint { get; set; }
        public bool HttpMethodAsScope { get; set; }
        public string Realm { get; set; }
        public string AuthServerUrl { get; set; }
        public Dictionary<string, object> Credentials { get; set; }
        public string Resource { get; set; }
    }
}
