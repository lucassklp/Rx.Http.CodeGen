namespace Keycloak.Models
{
    public class ManagementPermissionReference
    {
        public bool Enabled { get; set; }
        public string Resource { get; set; }
        public object ScopePermissions { get; set; }
    }
}
