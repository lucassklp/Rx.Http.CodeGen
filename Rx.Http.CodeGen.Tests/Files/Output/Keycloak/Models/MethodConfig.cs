namespace Keycloak.Models
{
    public class MethodConfig
    {
        public string Method { get; set; }
        public List<string> Scopes { get; set; }
        public ScopeEnforcementMode ScopesEnforcementMode { get; set; }
    }
}
