namespace Keycloak.Models
{
    public class MappingsRepresentation
    {
        public List<RoleRepresentation> RealmMappings { get; set; }
        public object ClientMappings { get; set; }
    }
}
