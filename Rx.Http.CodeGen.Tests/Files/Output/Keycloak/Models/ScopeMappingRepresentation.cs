using Newtonsoft.Json;

namespace Keycloak.Models
{
    public class ScopeMappingRepresentation
    {
        [JsonProperty("self")]
        public string Self { get; set; }
        [JsonProperty("client")]
        public string Client { get; set; }
        [JsonProperty("clientTemplate")]
        public string ClientTemplate { get; set; }
        [JsonProperty("clientScope")]
        public string ClientScope { get; set; }
        [JsonProperty("roles")]
        public List<string> Roles { get; set; }
    }
}
