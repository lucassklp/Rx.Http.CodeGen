using Newtonsoft.Json;

namespace Keycloak.Dict.Models
{
    public class ClientScopeRepresentation
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("protocol")]
        public string Protocol { get; set; }
        [JsonProperty("attributes")]
        public Dictionary<string, object> Attributes { get; set; }
        [JsonProperty("protocolMappers")]
        public List<ProtocolMapperRepresentation> ProtocolMappers { get; set; }
    }
}
