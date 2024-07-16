using Newtonsoft.Json;

namespace Keycloak.Models
{
    public class KeysMetadataRepresentation
    {
        [JsonProperty("active")]
        public object Active { get; set; }
        [JsonProperty("keys")]
        public List<KeyMetadataRepresentation> Keys { get; set; }
    }
}
