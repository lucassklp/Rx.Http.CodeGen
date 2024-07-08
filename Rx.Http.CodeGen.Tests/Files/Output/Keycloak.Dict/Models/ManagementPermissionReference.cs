namespace Keycloak.Dict.Models
{
    public class ManagementPermissionReference
    {
        public bool Enabled { get; set; }
        public string Resource { get; set; }
        public Dictionary<string, object> ScopePermissions { get; set; }
    }
}
