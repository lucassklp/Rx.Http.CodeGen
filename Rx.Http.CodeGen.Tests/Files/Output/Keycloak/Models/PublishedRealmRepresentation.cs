using Newtonsoft.Json;

namespace Keycloak.Models
{
    public class PublishedRealmRepresentation
    {
        [JsonProperty("realm")]
        public string Realm { get; set; }
        [JsonProperty("public_key")]
        public string PublicKey { get; set; }
        [JsonProperty("token-service")]
        public string TokenService { get; set; }
        [JsonProperty("account-service")]
        public string AccountService { get; set; }
        [JsonProperty("tokens-not-before")]
        public int TokensNotBefore { get; set; }
    }
}
