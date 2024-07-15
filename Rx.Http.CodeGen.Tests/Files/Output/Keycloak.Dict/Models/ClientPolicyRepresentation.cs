using Newtonsoft.Json;

namespace Keycloak.Dict.Models
{
    public class ClientPolicyRepresentation
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }
        [JsonProperty("conditions")]
        public List<ClientPolicyConditionRepresentation> Conditions { get; set; }
        [JsonProperty("profiles")]
        public List<string> Profiles { get; set; }
    }
}
