using Newtonsoft.Json;

namespace Keycloak.Dict.Models
{
    public class ConfigPropertyRepresentation
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("label")]
        public string Label { get; set; }
        [JsonProperty("helpText")]
        public string HelpText { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("defaultValue")]
        public Dictionary<string, object> DefaultValue { get; set; }
        [JsonProperty("options")]
        public List<string> Options { get; set; }
        [JsonProperty("secret")]
        public bool Secret { get; set; }
        [JsonProperty("readOnly")]
        public bool ReadOnly { get; set; }
    }
}
