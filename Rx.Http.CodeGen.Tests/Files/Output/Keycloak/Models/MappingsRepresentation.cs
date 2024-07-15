using Newtonsoft.Json;

namespace Keycloak.Models
{
    public class MappingsRepresentation
    {
        [JsonProperty("realmMappings")]
        public List<RoleRepresentation> RealmMappings { get; set; }
        [JsonProperty("clientMappings")]
        public object ClientMappings { get; set; }
    }
}
