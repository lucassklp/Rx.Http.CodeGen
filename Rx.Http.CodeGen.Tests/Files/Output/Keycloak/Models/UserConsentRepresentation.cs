using Newtonsoft.Json;

namespace Keycloak.Models
{
    public class UserConsentRepresentation
    {
        [JsonProperty("clientId")]
        public string ClientId { get; set; }
        [JsonProperty("grantedClientScopes")]
        public List<string> GrantedClientScopes { get; set; }
        [JsonProperty("createdDate")]
        public int CreatedDate { get; set; }
        [JsonProperty("lastUpdatedDate")]
        public int LastUpdatedDate { get; set; }
        [JsonProperty("grantedRealmRoles")]
        public List<string> GrantedRealmRoles { get; set; }
    }
}
