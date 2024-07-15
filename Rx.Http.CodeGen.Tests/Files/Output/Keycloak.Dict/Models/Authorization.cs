using Newtonsoft.Json;

namespace Keycloak.Dict.Models
{
    public class Authorization
    {
        [JsonProperty("permissions")]
        public List<Permission> Permissions { get; set; }
    }
}
