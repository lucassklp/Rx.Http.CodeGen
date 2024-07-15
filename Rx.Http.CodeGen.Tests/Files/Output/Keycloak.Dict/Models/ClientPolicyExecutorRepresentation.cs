using Newtonsoft.Json;

namespace Keycloak.Dict.Models
{
    public class ClientPolicyExecutorRepresentation
    {
        [JsonProperty("executor")]
        public string Executor { get; set; }
        [JsonProperty("configuration")]
        public List<Dictionary<string, object>> Configuration { get; set; }
    }
}
