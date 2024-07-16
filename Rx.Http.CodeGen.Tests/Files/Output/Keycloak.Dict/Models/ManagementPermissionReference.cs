using Newtonsoft.Json;

namespace Keycloak.Dict.Models
{
    public class ManagementPermissionReference
    {
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }
        [JsonProperty("resource")]
        public string Resource { get; set; }
        [JsonProperty("scopePermissions")]
        public Dictionary<string, object> ScopePermissions { get; set; }
    }
}
