namespace Keycloak.Models
{
    public class UserFederationMapperRepresentation
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string FederationProviderDisplayName { get; set; }
        public string FederationMapperType { get; set; }
        public object Config { get; set; }
    }
}
