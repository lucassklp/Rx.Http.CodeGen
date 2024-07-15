using Newtonsoft.Json;

namespace Keycloak.Dict.Models
{
    public class MappingsRepresentation
    {
        [JsonProperty("realmMappings")]
        public List<RoleRepresentation> RealmMappings { get; set; }
        [JsonProperty("clientMappings")]
        public Dictionary<string, object> ClientMappings { get; set; }
    }
}
