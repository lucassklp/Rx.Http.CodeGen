using Newtonsoft.Json;

namespace Keycloak.Models
{
    public class ClientMappingsRepresentation
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("client")]
        public string Client { get; set; }
        [JsonProperty("mappings")]
        public List<RoleRepresentation> Mappings { get; set; }
    }
}
