using Newtonsoft.Json;

namespace Keycloak.Dict.Models
{
    public class RolesRepresentation
    {
        [JsonProperty("realm")]
        public List<RoleRepresentation> Realm { get; set; }
        [JsonProperty("client")]
        public Dictionary<string, object> Client { get; set; }
        [JsonProperty("application")]
        public Dictionary<string, object> Application { get; set; }
    }
}
