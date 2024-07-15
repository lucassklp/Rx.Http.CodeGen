using Newtonsoft.Json;

namespace Keycloak.Dict.Models
{
    public class Composites
    {
        [JsonProperty("realm")]
        public List<string> Realm { get; set; }
        [JsonProperty("client")]
        public Dictionary<string, object> Client { get; set; }
        [JsonProperty("application")]
        public Dictionary<string, object> Application { get; set; }
    }
}
