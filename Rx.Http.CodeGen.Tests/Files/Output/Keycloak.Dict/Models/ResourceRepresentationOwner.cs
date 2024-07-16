using Newtonsoft.Json;

namespace Keycloak.Dict.Models
{
    public class ResourceRepresentationOwner
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
