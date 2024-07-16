using Newtonsoft.Json;

namespace Keycloak.Models
{
    public class ClaimRepresentation
    {
        [JsonProperty("name")]
        public bool Name { get; set; }
        [JsonProperty("username")]
        public bool Username { get; set; }
        [JsonProperty("profile")]
        public bool Profile { get; set; }
        [JsonProperty("picture")]
        public bool Picture { get; set; }
        [JsonProperty("website")]
        public bool Website { get; set; }
        [JsonProperty("email")]
        public bool Email { get; set; }
        [JsonProperty("gender")]
        public bool Gender { get; set; }
        [JsonProperty("locale")]
        public bool Locale { get; set; }
        [JsonProperty("address")]
        public bool Address { get; set; }
        [JsonProperty("phone")]
        public bool Phone { get; set; }
    }
}
