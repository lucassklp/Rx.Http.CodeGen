using Newtonsoft.Json;

namespace Keycloak.Models
{
    public class AuthenticatorConfigRepresentation
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("alias")]
        public string Alias { get; set; }
        [JsonProperty("config")]
        public object Config { get; set; }
    }
}
