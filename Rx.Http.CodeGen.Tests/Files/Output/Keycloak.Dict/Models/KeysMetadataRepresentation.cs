using Newtonsoft.Json;

namespace Keycloak.Dict.Models
{
    public class KeysMetadataRepresentation
    {
        [JsonProperty("active")]
        public Dictionary<string, object> Active { get; set; }
        [JsonProperty("keys")]
        public List<KeyMetadataRepresentation> Keys { get; set; }
    }
}
