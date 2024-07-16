using Newtonsoft.Json;

namespace Keycloak.Dict.Models
{
    public class ClientPolicyConditionRepresentation
    {
        [JsonProperty("condition")]
        public string Condition { get; set; }
        [JsonProperty("configuration")]
        public List<Dictionary<string, object>> Configuration { get; set; }
    }
}
