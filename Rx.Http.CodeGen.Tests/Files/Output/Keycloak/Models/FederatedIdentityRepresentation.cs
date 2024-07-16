using Newtonsoft.Json;

namespace Keycloak.Models
{
    public class FederatedIdentityRepresentation
    {
        [JsonProperty("identityProvider")]
        public string IdentityProvider { get; set; }
        [JsonProperty("userId")]
        public string UserId { get; set; }
        [JsonProperty("userName")]
        public string UserName { get; set; }
    }
}
