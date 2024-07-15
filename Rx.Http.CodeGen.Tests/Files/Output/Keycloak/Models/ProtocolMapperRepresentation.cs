using Newtonsoft.Json;

namespace Keycloak.Models
{
    public class ProtocolMapperRepresentation
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("protocol")]
        public string Protocol { get; set; }
        [JsonProperty("protocolMapper")]
        public string ProtocolMapper { get; set; }
        [JsonProperty("consentRequired")]
        public bool ConsentRequired { get; set; }
        [JsonProperty("consentText")]
        public string ConsentText { get; set; }
        [JsonProperty("config")]
        public object Config { get; set; }
    }
}
