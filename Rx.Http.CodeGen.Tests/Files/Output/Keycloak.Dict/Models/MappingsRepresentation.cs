namespace Keycloak.Dict.Models
{
    public class MappingsRepresentation
    {
        public List<RoleRepresentation> RealmMappings { get; set; }
        public Dictionary<string, object> ClientMappings { get; set; }
    }
}
