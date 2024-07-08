namespace Keycloak.Dict.Models
{
    public class RolesRepresentation
    {
        public List<RoleRepresentation> Realm { get; set; }
        public Dictionary<string, object> Client { get; set; }
        public Dictionary<string, object> Application { get; set; }
    }
}
