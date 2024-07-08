namespace Keycloak.Models
{
    public class RoleRepresentation
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool ScopeParamRequired { get; set; }
        public bool Composite { get; set; }
        public Composites Composites { get; set; }
        public bool ClientRole { get; set; }
        public string ContainerId { get; set; }
        public object Attributes { get; set; }
    }
}
