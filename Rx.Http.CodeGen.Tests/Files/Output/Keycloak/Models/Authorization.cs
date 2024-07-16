using Newtonsoft.Json;

namespace Keycloak.Models
{
    public class Authorization
    {
        [JsonProperty("permissions")]
        public List<Permission> Permissions { get; set; }
    }
}
