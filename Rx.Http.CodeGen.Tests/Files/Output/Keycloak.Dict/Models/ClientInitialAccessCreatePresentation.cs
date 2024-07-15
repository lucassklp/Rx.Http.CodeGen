using Newtonsoft.Json;

namespace Keycloak.Dict.Models
{
    public class ClientInitialAccessCreatePresentation
    {
        [JsonProperty("expiration")]
        public int Expiration { get; set; }
        [JsonProperty("count")]
        public int Count { get; set; }
    }
}
