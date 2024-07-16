using Newtonsoft.Json;

namespace Keycloak.Models
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
        public object Config { get; set; }
    }
}
