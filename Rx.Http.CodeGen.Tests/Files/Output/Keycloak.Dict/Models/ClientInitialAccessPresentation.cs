using Newtonsoft.Json;

namespace Keycloak.Dict.Models
{
    public class ClientInitialAccessPresentation
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("token")]
        public string Token { get; set; }
        [JsonProperty("timestamp")]
        public int Timestamp { get; set; }
        [JsonProperty("expiration")]
        public int Expiration { get; set; }
        [JsonProperty("count")]
        public int Count { get; set; }
        [JsonProperty("remainingCount")]
        public int RemainingCount { get; set; }
    }
}
