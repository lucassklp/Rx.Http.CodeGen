namespace Keycloak.Models
{
    public class IdentityProviderMapperRepresentation
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string IdentityProviderAlias { get; set; }
        public string IdentityProviderMapper { get; set; }
        public object Config { get; set; }
    }
}
