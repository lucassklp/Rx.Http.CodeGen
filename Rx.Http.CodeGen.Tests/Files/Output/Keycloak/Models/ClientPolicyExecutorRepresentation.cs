using Newtonsoft.Json;

namespace Keycloak.Models
{
    public class ClientPolicyExecutorRepresentation
    {
        [JsonProperty("executor")]
        public string Executor { get; set; }
        [JsonProperty("configuration")]
        public List<object> Configuration { get; set; }
    }
}
