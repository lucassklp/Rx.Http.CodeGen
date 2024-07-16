using Newtonsoft.Json;

namespace Keycloak.Models
{
    public class ClientTemplateRepresentation
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("protocol")]
        public string Protocol { get; set; }
        [JsonProperty("fullScopeAllowed")]
        public bool FullScopeAllowed { get; set; }
        [JsonProperty("bearerOnly")]
        public bool BearerOnly { get; set; }
        [JsonProperty("consentRequired")]
        public bool ConsentRequired { get; set; }
        [JsonProperty("standardFlowEnabled")]
        public bool StandardFlowEnabled { get; set; }
        [JsonProperty("implicitFlowEnabled")]
        public bool ImplicitFlowEnabled { get; set; }
        [JsonProperty("directAccessGrantsEnabled")]
        public bool DirectAccessGrantsEnabled { get; set; }
        [JsonProperty("serviceAccountsEnabled")]
        public bool ServiceAccountsEnabled { get; set; }
        [JsonProperty("publicClient")]
        public bool PublicClient { get; set; }
        [JsonProperty("frontchannelLogout")]
        public bool FrontchannelLogout { get; set; }
        [JsonProperty("attributes")]
        public object Attributes { get; set; }
        [JsonProperty("protocolMappers")]
        public List<ProtocolMapperRepresentation> ProtocolMappers { get; set; }
    }
}
