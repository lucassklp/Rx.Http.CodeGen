namespace Keycloak.Dict.Models
{
    public class InstallationAdapterConfig
    {
        public string Realm { get; set; }
        public string RealmPublicKey { get; set; }
        public string AuthServerUrl { get; set; }
        public string SslRequired { get; set; }
        public bool BearerOnly { get; set; }
        public string Resource { get; set; }
        public bool PublicClient { get; set; }
        public bool VerifyTokenAudience { get; set; }
        public Dictionary<string, object> Credentials { get; set; }
        public bool UseResourceRoleMappings { get; set; }
        public int ConfidentialPort { get; set; }
        public PolicyEnforcerConfig PolicyEnforcer { get; set; }
    }
}
