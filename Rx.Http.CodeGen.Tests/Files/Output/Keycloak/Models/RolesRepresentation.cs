namespace Keycloak.Models
{
    public class RolesRepresentation
    {
        public List<RoleRepresentation> Realm { get; set; }
        public object Client { get; set; }
        public object Application { get; set; }
    }
}
