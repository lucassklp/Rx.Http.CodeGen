using Newtonsoft.Json;

namespace Keycloak.Models
{
    public class ClientPolicyConditionRepresentation
    {
        [JsonProperty("condition")]
        public string Condition { get; set; }
        [JsonProperty("configuration")]
        public List<object> Configuration { get; set; }
    }
}
