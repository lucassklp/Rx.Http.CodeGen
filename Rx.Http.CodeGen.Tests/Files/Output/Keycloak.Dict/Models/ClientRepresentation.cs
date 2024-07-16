using Newtonsoft.Json;

namespace Keycloak.Dict.Models
{
    public class ClientRepresentation
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("clientId")]
        public string ClientId { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("rootUrl")]
        public string RootUrl { get; set; }
        [JsonProperty("adminUrl")]
        public string AdminUrl { get; set; }
        [JsonProperty("baseUrl")]
        public string BaseUrl { get; set; }
        [JsonProperty("surrogateAuthRequired")]
        public bool SurrogateAuthRequired { get; set; }
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }
        [JsonProperty("alwaysDisplayInConsole")]
        public bool AlwaysDisplayInConsole { get; set; }
        [JsonProperty("clientAuthenticatorType")]
        public string ClientAuthenticatorType { get; set; }
        [JsonProperty("secret")]
        public string Secret { get; set; }
        [JsonProperty("registrationAccessToken")]
        public string RegistrationAccessToken { get; set; }
        [JsonProperty("defaultRoles")]
        public List<string> DefaultRoles { get; set; }
        [JsonProperty("redirectUris")]
        public List<string> RedirectUris { get; set; }
        [JsonProperty("webOrigins")]
        public List<string> WebOrigins { get; set; }
        [JsonProperty("notBefore")]
        public int NotBefore { get; set; }
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
        [JsonProperty("oauth2DeviceAuthorizationGrantEnabled")]
        public bool Oauth2DeviceAuthorizationGrantEnabled { get; set; }
        [JsonProperty("authorizationServicesEnabled")]
        public bool AuthorizationServicesEnabled { get; set; }
        [JsonProperty("directGrantsOnly")]
        public bool DirectGrantsOnly { get; set; }
        [JsonProperty("publicClient")]
        public bool PublicClient { get; set; }
        [JsonProperty("frontchannelLogout")]
        public bool FrontchannelLogout { get; set; }
        [JsonProperty("protocol")]
        public string Protocol { get; set; }
        [JsonProperty("attributes")]
        public Dictionary<string, object> Attributes { get; set; }
        [JsonProperty("authenticationFlowBindingOverrides")]
        public Dictionary<string, object> AuthenticationFlowBindingOverrides { get; set; }
        [JsonProperty("fullScopeAllowed")]
        public bool FullScopeAllowed { get; set; }
        [JsonProperty("nodeReRegistrationTimeout")]
        public int NodeReRegistrationTimeout { get; set; }
        [JsonProperty("registeredNodes")]
        public Dictionary<string, object> RegisteredNodes { get; set; }
        [JsonProperty("protocolMappers")]
        public List<ProtocolMapperRepresentation> ProtocolMappers { get; set; }
        [JsonProperty("clientTemplate")]
        public string ClientTemplate { get; set; }
        [JsonProperty("useTemplateConfig")]
        public bool UseTemplateConfig { get; set; }
        [JsonProperty("useTemplateScope")]
        public bool UseTemplateScope { get; set; }
        [JsonProperty("useTemplateMappers")]
        public bool UseTemplateMappers { get; set; }
        [JsonProperty("defaultClientScopes")]
        public List<string> DefaultClientScopes { get; set; }
        [JsonProperty("optionalClientScopes")]
        public List<string> OptionalClientScopes { get; set; }
        [JsonProperty("authorizationSettings")]
        public ResourceServerRepresentation AuthorizationSettings { get; set; }
        [JsonProperty("access")]
        public Dictionary<string, object> Access { get; set; }
        [JsonProperty("origin")]
        public string Origin { get; set; }
    }
}
