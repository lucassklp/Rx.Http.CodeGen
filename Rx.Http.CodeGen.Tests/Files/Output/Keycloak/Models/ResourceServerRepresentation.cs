namespace Keycloak.Models
{
    public class ResourceServerRepresentation
    {
        public string Id { get; set; }
        public string ClientId { get; set; }
        public string Name { get; set; }
        public bool AllowRemoteResourceManagement { get; set; }
        public PolicyEnforcementMode PolicyEnforcementMode { get; set; }
        public List<ResourceRepresentation> Resources { get; set; }
        public List<PolicyRepresentation> Policies { get; set; }
        public List<ScopeRepresentation> Scopes { get; set; }
        public DecisionStrategy DecisionStrategy { get; set; }
    }
}
