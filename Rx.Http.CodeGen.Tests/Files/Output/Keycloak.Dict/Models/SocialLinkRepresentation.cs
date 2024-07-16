using Newtonsoft.Json;

namespace Keycloak.Dict.Models
{
    public class SocialLinkRepresentation
    {
        [JsonProperty("socialProvider")]
        public string SocialProvider { get; set; }
        [JsonProperty("socialUserId")]
        public string SocialUserId { get; set; }
        [JsonProperty("socialUsername")]
        public string SocialUsername { get; set; }
    }
}
