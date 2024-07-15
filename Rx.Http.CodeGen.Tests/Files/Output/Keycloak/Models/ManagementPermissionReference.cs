using Newtonsoft.Json;

namespace Keycloak.Models
{
    public class ManagementPermissionReference
    {
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }
        [JsonProperty("resource")]
        public string Resource { get; set; }
        [JsonProperty("scopePermissions")]
        public object ScopePermissions { get; set; }
    }
}
