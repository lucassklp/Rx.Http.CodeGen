using Newtonsoft.Json;

namespace Keycloak.Models
{
    public class ResourceOwnerRepresentation
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
