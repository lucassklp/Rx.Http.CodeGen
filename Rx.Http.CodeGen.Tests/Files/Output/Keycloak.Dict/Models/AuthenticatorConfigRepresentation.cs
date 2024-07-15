using Newtonsoft.Json;

namespace Keycloak.Dict.Models
{
    public class AuthenticatorConfigRepresentation
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("alias")]
        public string Alias { get; set; }
        [JsonProperty("config")]
        public Dictionary<string, object> Config { get; set; }
    }
}
