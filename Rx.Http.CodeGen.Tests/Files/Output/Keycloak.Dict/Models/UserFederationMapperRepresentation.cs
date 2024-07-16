using Newtonsoft.Json;

namespace Keycloak.Dict.Models
{
    public class UserFederationMapperRepresentation
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("federationProviderDisplayName")]
        public string FederationProviderDisplayName { get; set; }
        [JsonProperty("federationMapperType")]
        public string FederationMapperType { get; set; }
        [JsonProperty("config")]
        public Dictionary<string, object> Config { get; set; }
    }
}
