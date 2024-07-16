using Newtonsoft.Json;

namespace Keycloak.Dict.Models
{
    public class ComponentExportRepresentation
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("providerId")]
        public string ProviderId { get; set; }
        [JsonProperty("subType")]
        public string SubType { get; set; }
        [JsonProperty("subComponents")]
        public Dictionary<string, object> SubComponents { get; set; }
        [JsonProperty("config")]
        public Dictionary<string, object> Config { get; set; }
    }
}
