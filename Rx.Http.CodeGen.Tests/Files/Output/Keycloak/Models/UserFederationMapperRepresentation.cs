using Newtonsoft.Json;

namespace Keycloak.Models
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
        public object Config { get; set; }
    }
}
