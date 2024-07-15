using Newtonsoft.Json;

namespace Keycloak.Models
{
    public class ClientProfileRepresentation
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("executors")]
        public List<ClientPolicyExecutorRepresentation> Executors { get; set; }
    }
}
