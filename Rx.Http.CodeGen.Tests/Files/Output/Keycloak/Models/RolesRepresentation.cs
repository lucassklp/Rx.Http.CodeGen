using Newtonsoft.Json;

namespace Keycloak.Models
{
    public class RolesRepresentation
    {
        [JsonProperty("realm")]
        public List<RoleRepresentation> Realm { get; set; }
        [JsonProperty("client")]
        public object Client { get; set; }
        [JsonProperty("application")]
        public object Application { get; set; }
    }
}
