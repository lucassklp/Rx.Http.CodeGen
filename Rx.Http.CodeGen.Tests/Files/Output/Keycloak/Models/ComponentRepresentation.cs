namespace Keycloak.Models
{
    public class ComponentRepresentation
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string ProviderId { get; set; }
        public string ProviderType { get; set; }
        public string ParentId { get; set; }
        public string SubType { get; set; }
        public object Config { get; set; }
    }
}
