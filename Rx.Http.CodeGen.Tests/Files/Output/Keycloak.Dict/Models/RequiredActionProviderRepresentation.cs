using Newtonsoft.Json;

namespace Keycloak.Dict.Models
{
    public class RequiredActionProviderRepresentation
    {
        [JsonProperty("alias")]
        public string Alias { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("providerId")]
        public string ProviderId { get; set; }
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }
        [JsonProperty("defaultAction")]
        public bool DefaultAction { get; set; }
        [JsonProperty("priority")]
        public int Priority { get; set; }
        [JsonProperty("config")]
        public Dictionary<string, object> Config { get; set; }
    }
}
