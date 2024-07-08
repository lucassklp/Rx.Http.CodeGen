namespace Keycloak.Dict.Models
{
    public class PolicyRepresentation
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public List<string> Policies { get; set; }
        public List<string> Resources { get; set; }
        public List<string> Scopes { get; set; }
        public Logic Logic { get; set; }
        public DecisionStrategy DecisionStrategy { get; set; }
        public string Owner { get; set; }
        public List<ResourceRepresentation> ResourcesData { get; set; }
        public List<ScopeRepresentation> ScopesData { get; set; }
        public Dictionary<string, object> Config { get; set; }
    }
}
