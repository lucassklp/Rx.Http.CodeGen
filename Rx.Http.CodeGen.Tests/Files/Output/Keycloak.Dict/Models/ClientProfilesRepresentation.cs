using Newtonsoft.Json;

namespace Keycloak.Dict.Models
{
    public class ClientProfilesRepresentation
    {
        [JsonProperty("profiles")]
        public List<ClientProfileRepresentation> Profiles { get; set; }
        [JsonProperty("globalProfiles")]
        public List<ClientProfileRepresentation> GlobalProfiles { get; set; }
    }
}
