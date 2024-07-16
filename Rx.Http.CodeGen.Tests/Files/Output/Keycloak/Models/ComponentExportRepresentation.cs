using Newtonsoft.Json;

namespace Keycloak.Models
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
        public object SubComponents { get; set; }
        [JsonProperty("config")]
        public object Config { get; set; }
    }
}
