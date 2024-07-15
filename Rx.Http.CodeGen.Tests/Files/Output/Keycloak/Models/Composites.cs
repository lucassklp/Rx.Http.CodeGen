using Newtonsoft.Json;

namespace Keycloak.Models
{
    public class Composites
    {
        [JsonProperty("realm")]
        public List<string> Realm { get; set; }
        [JsonProperty("client")]
        public object Client { get; set; }
        [JsonProperty("application")]
        public object Application { get; set; }
    }
}
