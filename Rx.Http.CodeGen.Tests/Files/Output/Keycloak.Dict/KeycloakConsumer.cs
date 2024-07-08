using System;
using Rx.Http;
using Rx.Http.Extensions;
using Keycloak.Dict.Models;

namespace Keycloak.Dict
{
    class KeycloakConsumer : RxHttpClient
    {
        public KeycloakConsumer(HttpClient httpClient) : base(httpClient, null)
        {
            httpClient.BaseAddress = new Uri("https://keycloak.example.com/admin/realms");
            RequestInterceptors.Add(new KeycloakTokenInterceptor());
        }

        public IObservable<Dictionary<string, object>> Get(string briefRepresentation)
        {
            return base.Get<Dictionary<string, object>>($"/", null, options => {
                options.AddQueryString("briefRepresentation", briefRepresentation);
            });
        }
        public IObservable<RxHttpResponse> Post(string body)
        {
            return base.Post($"/", body);
        }
        public IObservable<RealmRepresentation> GetByRealm(string realm)
        {
            return base.Get<RealmRepresentation>($"/{realm}");
        }
        public IObservable<RxHttpResponse> PutByRealm(RealmRepresentation body, string realm)
        {
            return Put($"/{realm}", body);
        }
        public IObservable<RxHttpResponse> DeleteByRealm(string realm)
        {
            return Delete($"/{realm}");
        }
        public IObservable<Dictionary<string, object>> GetAdminEvents(string authClient, string authIpAddress, string authRealm, string authUser, string dateFrom, string dateTo, string first, string max, string operationTypes, string resourcePath, string resourceTypes, string realm)
        {
            return base.Get<Dictionary<string, object>>($"/{realm}/adminEvents", null, options => {
                options.AddQueryString("authClient", authClient);
                options.AddQueryString("authIpAddress", authIpAddress);
                options.AddQueryString("authRealm", authRealm);
                options.AddQueryString("authUser", authUser);
                options.AddQueryString("dateFrom", dateFrom);
                options.AddQueryString("dateTo", dateTo);
                options.AddQueryString("first", first);
                options.AddQueryString("max", max);
                options.AddQueryString("operationTypes", operationTypes);
                options.AddQueryString("resourcePath", resourcePath);
                options.AddQueryString("resourceTypes", resourceTypes);
            });
        }
        public IObservable<RxHttpResponse> DeleteAdminEvents(string realm)
        {
            return Delete($"/{realm}/adminEvents");
        }
        public IObservable<RxHttpResponse> DeleteUsers(string realm)
        {
            return Delete($"/{realm}/attackDetection/bruteForce/users");
        }
        public IObservable<Dictionary<string, object>> GetBruteForceUser(string realm, string userId)
        {
            return base.Get<Dictionary<string, object>>($"/{realm}/attackDetection/bruteForce/users/{userId}");
        }
        public IObservable<RxHttpResponse> DeleteBruteForceUser(string realm, string userId)
        {
            return Delete($"/{realm}/attackDetection/bruteForce/users/{userId}");
        }
        public IObservable<Dictionary<string, object>> GetAuthenticatorProviders(string realm)
        {
            return base.Get<Dictionary<string, object>>($"/{realm}/authentication/authenticatorProviders");
        }
        public IObservable<Dictionary<string, object>> GetClientAuthenticatorProviders(string realm)
        {
            return base.Get<Dictionary<string, object>>($"/{realm}/authentication/clientAuthenticatorProviders");
        }
        public IObservable<RxHttpResponse> PostAuthenticationConfig(AuthenticatorConfigRepresentation body, string realm)
        {
            return base.Post($"/{realm}/authentication/config", body);
        }
        public IObservable<AuthenticatorConfigInfoRepresentation> GetConfigDescription(string realm, string providerId)
        {
            return base.Get<AuthenticatorConfigInfoRepresentation>($"/{realm}/authentication/configDescription/{providerId}");
        }
        public IObservable<AuthenticatorConfigRepresentation> GetAuthenticationConfig(string realm, string id)
        {
            return base.Get<AuthenticatorConfigRepresentation>($"/{realm}/authentication/config/{id}");
        }
        public IObservable<RxHttpResponse> PutAuthenticationConfig(AuthenticatorConfigRepresentation body, string realm, string id)
        {
            return Put($"/{realm}/authentication/config/{id}", body);
        }
        public IObservable<RxHttpResponse> DeleteConfig(string realm, string id)
        {
            return Delete($"/{realm}/authentication/config/{id}");
        }
        public IObservable<RxHttpResponse> PostExecutions(AuthenticationExecutionRepresentation body, string realm)
        {
            return base.Post($"/{realm}/authentication/executions", body);
        }
        public IObservable<RxHttpResponse> GetExecution(string realm, string executionId)
        {
            return base.Get($"/{realm}/authentication/executions/{executionId}");
        }
        public IObservable<RxHttpResponse> DeleteExecution(string realm, string executionId)
        {
            return Delete($"/{realm}/authentication/executions/{executionId}");
        }
        public IObservable<RxHttpResponse> PostExecutionConfig(AuthenticatorConfigRepresentation body, string realm, string executionId)
        {
            return base.Post($"/{realm}/authentication/executions/{executionId}/config", body);
        }
        public IObservable<AuthenticatorConfigRepresentation> GetExecutionConfig(string realm, string executionId, string id)
        {
            return base.Get<AuthenticatorConfigRepresentation>($"/{realm}/authentication/executions/{executionId}/config/{id}");
        }
        public IObservable<RxHttpResponse> PostExecutionLowerPriority(string realm, string executionId)
        {
            return base.Post($"/{realm}/authentication/executions/{executionId}/lowerPriority");
        }
        public IObservable<RxHttpResponse> PostExecutionRaisePriority(string realm, string executionId)
        {
            return base.Post($"/{realm}/authentication/executions/{executionId}/raisePriority");
        }
        public IObservable<Dictionary<string, object>> GetFlows(string realm)
        {
            return base.Get<Dictionary<string, object>>($"/{realm}/authentication/flows");
        }
        public IObservable<RxHttpResponse> PostFlows(AuthenticationFlowRepresentation body, string realm)
        {
            return base.Post($"/{realm}/authentication/flows", body);
        }
        public IObservable<RxHttpResponse> PostCopy(string body, string realm, string flowAlias)
        {
            return base.Post($"/{realm}/authentication/flows/{flowAlias}/copy", body);
        }
        public IObservable<RxHttpResponse> GetExecutions(string realm, string flowAlias)
        {
            return base.Get($"/{realm}/authentication/flows/{flowAlias}/executions");
        }
        public IObservable<RxHttpResponse> PutExecutions(AuthenticationExecutionInfoRepresentation body, string realm, string flowAlias)
        {
            return Put($"/{realm}/authentication/flows/{flowAlias}/executions", body);
        }
        public IObservable<RxHttpResponse> PostExecution(string body, string realm, string flowAlias)
        {
            return base.Post($"/{realm}/authentication/flows/{flowAlias}/executions/execution", body);
        }
        public IObservable<RxHttpResponse> PostFlow(string body, string realm, string flowAlias)
        {
            return base.Post($"/{realm}/authentication/flows/{flowAlias}/executions/flow", body);
        }
        public IObservable<AuthenticationFlowRepresentation> GetFlow(string realm, string id)
        {
            return base.Get<AuthenticationFlowRepresentation>($"/{realm}/authentication/flows/{id}");
        }
        public IObservable<RxHttpResponse> PutFlow(AuthenticationFlowRepresentation body, string realm, string id)
        {
            return Put($"/{realm}/authentication/flows/{id}", body);
        }
        public IObservable<RxHttpResponse> DeleteFlow(string realm, string id)
        {
            return Delete($"/{realm}/authentication/flows/{id}");
        }
        public IObservable<Dictionary<string, object>> GetFormActionProviders(string realm)
        {
            return base.Get<Dictionary<string, object>>($"/{realm}/authentication/formActionProviders");
        }
        public IObservable<Dictionary<string, object>> GetFormProviders(string realm)
        {
            return base.Get<Dictionary<string, object>>($"/{realm}/authentication/formProviders");
        }
        public IObservable<Dictionary<string, object>> GetPerClientConfigDescription(string realm)
        {
            return base.Get<Dictionary<string, object>>($"/{realm}/authentication/perClientConfigDescription");
        }
        public IObservable<RxHttpResponse> PostRegisterRequiredAction(string body, string realm)
        {
            return base.Post($"/{realm}/authentication/registerRequiredAction", body);
        }
        public IObservable<Dictionary<string, object>> GetRequiredActions(string realm)
        {
            return base.Get<Dictionary<string, object>>($"/{realm}/authentication/requiredActions");
        }
        public IObservable<RequiredActionProviderRepresentation> GetRequiredAction(string realm, string alias)
        {
            return base.Get<RequiredActionProviderRepresentation>($"/{realm}/authentication/requiredActions/{alias}");
        }
        public IObservable<RxHttpResponse> PutRequiredAction(RequiredActionProviderRepresentation body, string realm, string alias)
        {
            return Put($"/{realm}/authentication/requiredActions/{alias}", body);
        }
        public IObservable<RxHttpResponse> DeleteRequiredAction(string realm, string alias)
        {
            return Delete($"/{realm}/authentication/requiredActions/{alias}");
        }
        public IObservable<RxHttpResponse> PostRequiredActionLowerPriority(string realm, string alias)
        {
            return base.Post($"/{realm}/authentication/requiredActions/{alias}/lowerPriority");
        }
        public IObservable<RxHttpResponse> PostRequiredActionRaisePriority(string realm, string alias)
        {
            return base.Post($"/{realm}/authentication/requiredActions/{alias}/raisePriority");
        }
        public IObservable<Dictionary<string, object>> GetUnregisteredRequiredActions(string realm)
        {
            return base.Get<Dictionary<string, object>>($"/{realm}/authentication/unregisteredRequiredActions");
        }
        public IObservable<ClientRepresentation> PostClientDescriptionConverter(string body, string realm)
        {
            return base.Post<ClientRepresentation>($"/{realm}/clientDescriptionConverter", body);
        }
        public IObservable<ClientPoliciesRepresentation> GetPolicies(string realm)
        {
            return base.Get<ClientPoliciesRepresentation>($"/{realm}/clientPolicies/policies");
        }
        public IObservable<RxHttpResponse> PutPolicies(ClientPoliciesRepresentation body, string realm)
        {
            return Put($"/{realm}/clientPolicies/policies", body);
        }
        public IObservable<ClientProfilesRepresentation> GetProfiles(string includeGlobalProfiles, string realm)
        {
            return base.Get<ClientProfilesRepresentation>($"/{realm}/clientPolicies/profiles", null, options => {
                options.AddQueryString("include-global-profiles", includeGlobalProfiles);
            });
        }
        public IObservable<RxHttpResponse> PutProfiles(ClientProfilesRepresentation body, string realm)
        {
            return Put($"/{realm}/clientPolicies/profiles", body);
        }
        public IObservable<Dictionary<string, object>> GetProviders(string realm)
        {
            return base.Get<Dictionary<string, object>>($"/{realm}/clientRegistrationPolicy/providers");
        }
        public IObservable<Dictionary<string, object>> GetClientScopes(string realm)
        {
            return base.Get<Dictionary<string, object>>($"/{realm}/clientScopes");
        }
        public IObservable<RxHttpResponse> PostClientScopes(ClientScopeRepresentation body, string realm)
        {
            return base.Post($"/{realm}/clientScopes", body);
        }
        public IObservable<ProtocolMapperRepresentation> GetClientScopeProtocolMappersModel(string realm, string id1, string id2)
        {
            return base.Get<ProtocolMapperRepresentation>($"/{realm}/clientScopes/{id1}/protocolMappers/models/{id2}");
        }
        public IObservable<RxHttpResponse> PutClientScopeProtocolMappersModel(ProtocolMapperRepresentation body, string realm, string id1, string id2)
        {
            return Put($"/{realm}/clientScopes/{id1}/protocolMappers/models/{id2}", body);
        }
        public IObservable<RxHttpResponse> DeleteClientScopeProtocolMappersModel(string realm, string id1, string id2)
        {
            return Delete($"/{realm}/clientScopes/{id1}/protocolMappers/models/{id2}");
        }
        public IObservable<ClientScopeRepresentation> GetClientScope(string realm, string id)
        {
            return base.Get<ClientScopeRepresentation>($"/{realm}/clientScopes/{id}");
        }
        public IObservable<RxHttpResponse> PutClientScope(ClientScopeRepresentation body, string realm, string id)
        {
            return Put($"/{realm}/clientScopes/{id}", body);
        }
        public IObservable<RxHttpResponse> DeleteClientScope(string realm, string id)
        {
            return Delete($"/{realm}/clientScopes/{id}");
        }
        public IObservable<RxHttpResponse> PostClientScopeProtocolMappersAddModels(ProtocolMapperRepresentation body, string realm, string id)
        {
            return base.Post($"/{realm}/clientScopes/{id}/protocolMappers/addModels", body);
        }
        public IObservable<Dictionary<string, object>> GetClientScopeProtocolMappersModels(string realm, string id)
        {
            return base.Get<Dictionary<string, object>>($"/{realm}/clientScopes/{id}/protocolMappers/models");
        }
        public IObservable<RxHttpResponse> PostClientScopeProtocolMappersModels(ProtocolMapperRepresentation body, string realm, string id)
        {
            return base.Post($"/{realm}/clientScopes/{id}/protocolMappers/models", body);
        }
        public IObservable<Dictionary<string, object>> GetClientScopeProtocolMappersProtocol(string realm, string id, string protocol)
        {
            return base.Get<Dictionary<string, object>>($"/{realm}/clientScopes/{id}/protocolMappers/protocol/{protocol}");
        }
        public IObservable<MappingsRepresentation> GetClientScopeScopeMappings(string realm, string id)
        {
            return base.Get<MappingsRepresentation>($"/{realm}/clientScopes/{id}/scopeMappings");
        }
        public IObservable<Dictionary<string, object>> GetClientScopeScopeMappingsClient(string realm, string id, string client)
        {
            return base.Get<Dictionary<string, object>>($"/{realm}/clientScopes/{id}/scopeMappings/clients/{client}");
        }
        public IObservable<RxHttpResponse> PostClientScopeScopeMappingsClient(RoleRepresentation body, string realm, string id, string client)
        {
            return base.Post($"/{realm}/clientScopes/{id}/scopeMappings/clients/{client}", body);
        }
        public IObservable<RxHttpResponse> DeleteClientScopeScopeMappingsClient(RoleRepresentation body, string realm, string id, string client)
        {
            return Delete($"/{realm}/clientScopes/{id}/scopeMappings/clients/{client}", body);
        }
        public IObservable<Dictionary<string, object>> GetClientScopeScopeMappingsClientAvailable(string realm, string id, string client)
        {
            return base.Get<Dictionary<string, object>>($"/{realm}/clientScopes/{id}/scopeMappings/clients/{client}/available");
        }
        public IObservable<Dictionary<string, object>> GetClientScopeScopeMappingsClientComposite(string briefRepresentation, string realm, string id, string client)
        {
            return base.Get<Dictionary<string, object>>($"/{realm}/clientScopes/{id}/scopeMappings/clients/{client}/composite", null, options => {
                options.AddQueryString("briefRepresentation", briefRepresentation);
            });
        }
        public IObservable<Dictionary<string, object>> GetClientScopeScopeMappingsRealm(string realm, string id)
        {
            return base.Get<Dictionary<string, object>>($"/{realm}/clientScopes/{id}/scopeMappings/realm");
        }
        public IObservable<RxHttpResponse> PostClientScopeScopeMappingsRealm(RoleRepresentation body, string realm, string id)
        {
            return base.Post($"/{realm}/clientScopes/{id}/scopeMappings/realm", body);
        }
        public IObservable<RxHttpResponse> DeleteClientScopeScopeMappingsRealm(RoleRepresentation body, string realm, string id)
        {
            return Delete($"/{realm}/clientScopes/{id}/scopeMappings/realm", body);
        }
        public IObservable<Dictionary<string, object>> GetClientScopeScopeMappingsRealmAvailable(string realm, string id)
        {
            return base.Get<Dictionary<string, object>>($"/{realm}/clientScopes/{id}/scopeMappings/realm/available");
        }
        public IObservable<Dictionary<string, object>> GetClientScopeScopeMappingsRealmComposite(string briefRepresentation, string realm, string id)
        {
            return base.Get<Dictionary<string, object>>($"/{realm}/clientScopes/{id}/scopeMappings/realm/composite", null, options => {
                options.AddQueryString("briefRepresentation", briefRepresentation);
            });
        }
        public IObservable<Dictionary<string, object>> GetClientSessionStats(string realm)
        {
            return base.Get<Dictionary<string, object>>($"/{realm}/clientSessionStats");
        }
        public IObservable<Dictionary<string, object>> GetClientTemplates(string realm)
        {
            return base.Get<Dictionary<string, object>>($"/{realm}/clientTemplates");
        }
        public IObservable<RxHttpResponse> PostClientTemplates(ClientScopeRepresentation body, string realm)
        {
            return base.Post($"/{realm}/clientTemplates", body);
        }
        public IObservable<ProtocolMapperRepresentation> GetClientTemplateProtocolMappersModel(string realm, string id1, string id2)
        {
            return base.Get<ProtocolMapperRepresentation>($"/{realm}/clientTemplates/{id1}/protocolMappers/models/{id2}");
        }
        public IObservable<RxHttpResponse> PutClientTemplateProtocolMappersModel(ProtocolMapperRepresentation body, string realm, string id1, string id2)
        {
            return Put($"/{realm}/clientTemplates/{id1}/protocolMappers/models/{id2}", body);
        }
        public IObservable<RxHttpResponse> DeleteClientTemplateProtocolMappersModel(string realm, string id1, string id2)
        {
            return Delete($"/{realm}/clientTemplates/{id1}/protocolMappers/models/{id2}");
        }
        public IObservable<ClientScopeRepresentation> GetClientTemplate(string realm, string id)
        {
            return base.Get<ClientScopeRepresentation>($"/{realm}/clientTemplates/{id}");
        }
        public IObservable<RxHttpResponse> PutClientTemplate(ClientScopeRepresentation body, string realm, string id)
        {
            return Put($"/{realm}/clientTemplates/{id}", body);
        }
        public IObservable<RxHttpResponse> DeleteClientTemplate(string realm, string id)
        {
            return Delete($"/{realm}/clientTemplates/{id}");
        }
        public IObservable<RxHttpResponse> PostClientTemplateProtocolMappersAddModels(ProtocolMapperRepresentation body, string realm, string id)
        {
            return base.Post($"/{realm}/clientTemplates/{id}/protocolMappers/addModels", body);
        }
        public IObservable<Dictionary<string, object>> GetClientTemplateProtocolMappersModels(string realm, string id)
        {
            return base.Get<Dictionary<string, object>>($"/{realm}/clientTemplates/{id}/protocolMappers/models");
        }
        public IObservable<RxHttpResponse> PostClientTemplateProtocolMappersModels(ProtocolMapperRepresentation body, string realm, string id)
        {
            return base.Post($"/{realm}/clientTemplates/{id}/protocolMappers/models", body);
        }
        public IObservable<Dictionary<string, object>> GetClientTemplateProtocolMappersProtocol(string realm, string id, string protocol)
        {
            return base.Get<Dictionary<string, object>>($"/{realm}/clientTemplates/{id}/protocolMappers/protocol/{protocol}");
        }
        public IObservable<MappingsRepresentation> GetClientTemplateScopeMappings(string realm, string id)
        {
            return base.Get<MappingsRepresentation>($"/{realm}/clientTemplates/{id}/scopeMappings");
        }
        public IObservable<Dictionary<string, object>> GetClientTemplateScopeMappingsClient(string realm, string id, string client)
        {
            return base.Get<Dictionary<string, object>>($"/{realm}/clientTemplates/{id}/scopeMappings/clients/{client}");
        }
        public IObservable<RxHttpResponse> PostClientTemplateScopeMappingsClient(RoleRepresentation body, string realm, string id, string client)
        {
            return base.Post($"/{realm}/clientTemplates/{id}/scopeMappings/clients/{client}", body);
        }
        public IObservable<RxHttpResponse> DeleteClientTemplateScopeMappingsClient(RoleRepresentation body, string realm, string id, string client)
        {
            return Delete($"/{realm}/clientTemplates/{id}/scopeMappings/clients/{client}", body);
        }
        public IObservable<Dictionary<string, object>> GetClientTemplateScopeMappingsClientAvailable(string realm, string id, string client)
        {
            return base.Get<Dictionary<string, object>>($"/{realm}/clientTemplates/{id}/scopeMappings/clients/{client}/available");
        }
        public IObservable<Dictionary<string, object>> GetClientTemplateScopeMappingsClientComposite(string briefRepresentation, string realm, string id, string client)
        {
            return base.Get<Dictionary<string, object>>($"/{realm}/clientTemplates/{id}/scopeMappings/clients/{client}/composite", null, options => {
                options.AddQueryString("briefRepresentation", briefRepresentation);
            });
        }
        public IObservable<Dictionary<string, object>> GetClientTemplateScopeMappingsRealm(string realm, string id)
        {
            return base.Get<Dictionary<string, object>>($"/{realm}/clientTemplates/{id}/scopeMappings/realm");
        }
        public IObservable<RxHttpResponse> PostClientTemplateScopeMappingsRealm(RoleRepresentation body, string realm, string id)
        {
            return base.Post($"/{realm}/clientTemplates/{id}/scopeMappings/realm", body);
        }
        public IObservable<RxHttpResponse> DeleteClientTemplateScopeMappingsRealm(RoleRepresentation body, string realm, string id)
        {
            return Delete($"/{realm}/clientTemplates/{id}/scopeMappings/realm", body);
        }
        public IObservable<Dictionary<string, object>> GetClientTemplateScopeMappingsRealmAvailable(string realm, string id)
        {
            return base.Get<Dictionary<string, object>>($"/{realm}/clientTemplates/{id}/scopeMappings/realm/available");
        }
        public IObservable<Dictionary<string, object>> GetClientTemplateScopeMappingsRealmComposite(string briefRepresentation, string realm, string id)
        {
            return base.Get<Dictionary<string, object>>($"/{realm}/clientTemplates/{id}/scopeMappings/realm/composite", null, options => {
                options.AddQueryString("briefRepresentation", briefRepresentation);
            });
        }
        public IObservable<Dictionary<string, object>> GetClients(string clientId, string first, string max, string q, string search, string viewableOnly, string realm)
        {
            return base.Get<Dictionary<string, object>>($"/{realm}/clients", null, options => {
                options.AddQueryString("clientId", clientId);
                options.AddQueryString("first", first);
                options.AddQueryString("max", max);
                options.AddQueryString("q", q);
                options.AddQueryString("search", search);
                options.AddQueryString("viewableOnly", viewableOnly);
            });
        }
        public IObservable<RxHttpResponse> PostClients(ClientRepresentation body, string realm)
        {
            return base.Post($"/{realm}/clients", body);
        }
        public IObservable<Dictionary<string, object>> GetClientsInitialAccess(string realm)
        {
            return base.Get<Dictionary<string, object>>($"/{realm}/clientsInitialAccess");
        }
        public IObservable<ClientInitialAccessPresentation> PostClientsInitialAccess(ClientInitialAccessCreatePresentation body, string realm)
        {
            return base.Post<ClientInitialAccessPresentation>($"/{realm}/clientsInitialAccess", body);
        }
        public IObservable<RxHttpResponse> DeleteClientsInitialAcces(string realm, string id)
        {
            return Delete($"/{realm}/clientsInitialAccess/{id}");
        }
        public IObservable<ProtocolMapperRepresentation> GetClientProtocolMappersModel(string realm, string id1, string id2)
        {
            return base.Get<ProtocolMapperRepresentation>($"/{realm}/clients/{id1}/protocolMappers/models/{id2}");
        }
        public IObservable<RxHttpResponse> PutClientProtocolMappersModel(ProtocolMapperRepresentation body, string realm, string id1, string id2)
        {
            return Put($"/{realm}/clients/{id1}/protocolMappers/models/{id2}", body);
        }
        public IObservable<RxHttpResponse> DeleteClientProtocolMappersModel(string realm, string id1, string id2)
        {
            return Delete($"/{realm}/clients/{id1}/protocolMappers/models/{id2}");
        }
        public IObservable<ClientRepresentation> GetClientByRealmById(string realm, string id)
        {
            return base.Get<ClientRepresentation>($"/{realm}/clients/{id}");
        }
        public IObservable<RxHttpResponse> PutClient(ClientRepresentation body, string realm, string id)
        {
            return Put($"/{realm}/clients/{id}", body);
        }
        public IObservable<RxHttpResponse> DeleteClientByRealmById(string realm, string id)
        {
            return Delete($"/{realm}/clients/{id}");
        }
        public IObservable<CertificateRepresentation> GetCertificate(string realm, string id, string attr)
        {
            return base.Get<CertificateRepresentation>($"/{realm}/clients/{id}/certificates/{attr}");
        }
        public IObservable<RxHttpResponse> PostDownload(KeyStoreConfig body, string realm, string id, string attr)
        {
            return base.Post($"/{realm}/clients/{id}/certificates/{attr}/download", body);
        }
        public IObservable<CertificateRepresentation> PostGenerate(string realm, string id, string attr)
        {
            return base.Post<CertificateRepresentation>($"/{realm}/clients/{id}/certificates/{attr}/generate");
        }
        public IObservable<RxHttpResponse> PostGenerateAndDownload(KeyStoreConfig body, string realm, string id, string attr)
        {
            return base.Post($"/{realm}/clients/{id}/certificates/{attr}/generateAndDownload", body);
        }
        public IObservable<CertificateRepresentation> PostUpload(string realm, string id, string attr)
        {
            return base.Post<CertificateRepresentation>($"/{realm}/clients/{id}/certificates/{attr}/upload");
        }
        public IObservable<CertificateRepresentation> PostUploadCertificate(string realm, string id, string attr)
        {
            return base.Post<CertificateRepresentation>($"/{realm}/clients/{id}/certificates/{attr}/uploadCertificate");
        }
        public IObservable<CredentialRepresentation> GetClientSecret(string realm, string id)
        {
            return base.Get<CredentialRepresentation>($"/{realm}/clients/{id}/clientSecret");
        }
        public IObservable<CredentialRepresentation> PostClientSecret(string realm, string id)
        {
            return base.Post<CredentialRepresentation>($"/{realm}/clients/{id}/clientSecret");
        }
        public IObservable<CredentialRepresentation> GetRotated(string realm, string id)
        {
            return base.Get<CredentialRepresentation>($"/{realm}/clients/{id}/clientSecret/rotated");
        }
        public IObservable<RxHttpResponse> DeleteRotated(string realm, string id)
        {
            return Delete($"/{realm}/clients/{id}/clientSecret/rotated");
        }
        public IObservable<Dictionary<string, object>> GetDefaultClientScopes(string realm, string id)
        {
            return base.Get<Dictionary<string, object>>($"/{realm}/clients/{id}/defaultClientScopes");
        }
        public IObservable<RxHttpResponse> PutDefaultClientScope(string realm, string id, string clientScopeId)
        {
            return Put($"/{realm}/clients/{id}/defaultClientScopes/{clientScopeId}");
        }
        public IObservable<RxHttpResponse> DeleteDefaultClientScope(string realm, string id, string clientScopeId)
        {
            return Delete($"/{realm}/clients/{id}/defaultClientScopes/{clientScopeId}");
        }
        public IObservable<AccessToken> GetGenerateExampleAccessToken(string scope, string userId, string realm, string id)
        {
            return base.Get<AccessToken>($"/{realm}/clients/{id}/evaluateScopes/generateExampleAccessToken", null, options => {
                options.AddQueryString("scope", scope);
                options.AddQueryString("userId", userId);
            });
        }
        public IObservable<IdToken> GetGenerateExampleIdToken(string scope, string userId, string realm, string id)
        {
            return base.Get<IdToken>($"/{realm}/clients/{id}/evaluateScopes/generateExampleIdToken", null, options => {
                options.AddQueryString("scope", scope);
                options.AddQueryString("userId", userId);
            });
        }
        public IObservable<Dictionary<string, object>> GetGenerateExampleUserinfo(string scope, string userId, string realm, string id)
        {
            return base.Get<Dictionary<string, object>>($"/{realm}/clients/{id}/evaluateScopes/generateExampleUserinfo", null, options => {
                options.AddQueryString("scope", scope);
                options.AddQueryString("userId", userId);
            });
        }
        public IObservable<Dictionary<string, object>> GetProtocolMappers(string scope, string realm, string id)
        {
            return base.Get<Dictionary<string, object>>($"/{realm}/clients/{id}/evaluateScopes/protocolMappers", null, options => {
                options.AddQueryString("scope", scope);
            });
        }
        public IObservable<Dictionary<string, object>> GetGranted(string scope, string realm, string id, string roleContainerId)
        {
            return base.Get<Dictionary<string, object>>($"/{realm}/clients/{id}/evaluateScopes/scopeMappings/{roleContainerId}/granted", null, options => {
                options.AddQueryString("scope", scope);
            });
        }
        public IObservable<Dictionary<string, object>> GetNotGranted(string scope, string realm, string id, string roleContainerId)
        {
            return base.Get<Dictionary<string, object>>($"/{realm}/clients/{id}/evaluateScopes/scopeMappings/{roleContainerId}/notGranted", null, options => {
                options.AddQueryString("scope", scope);
            });
        }
        public IObservable<RxHttpResponse> GetInstallationProvider(string realm, string id, string providerId)
        {
            return base.Get($"/{realm}/clients/{id}/installation/providers/{providerId}");
        }
        public IObservable<ManagementPermissionReference> GetClientManagementPermissions(string realm, string id)
        {
            return base.Get<ManagementPermissionReference>($"/{realm}/clients/{id}/management/permissions");
        }
        public IObservable<ManagementPermissionReference> PutClientManagementPermissions(ManagementPermissionReference body, string realm, string id)
        {
            return Put<ManagementPermissionReference>($"/{realm}/clients/{id}/management/permissions", body);
        }
        public IObservable<RxHttpResponse> PostNodes(string body, string realm, string id)
        {
            return base.Post($"/{realm}/clients/{id}/nodes", body);
        }
        public IObservable<RxHttpResponse> DeleteNode(string realm, string id, string node)
        {
            return Delete($"/{realm}/clients/{id}/nodes/{node}");
        }
        public IObservable<Dictionary<string, object>> GetOfflineSessionCount(string realm, string id)
        {
            return base.Get<Dictionary<string, object>>($"/{realm}/clients/{id}/offlineSessionCount");
        }
        public IObservable<Dictionary<string, object>> GetOfflineSessions(string first, string max, string realm, string id)
        {
            return base.Get<Dictionary<string, object>>($"/{realm}/clients/{id}/offlineSessions", null, options => {
                options.AddQueryString("first", first);
                options.AddQueryString("max", max);
            });
        }
        public IObservable<Dictionary<string, object>> GetOptionalClientScopes(string realm, string id)
        {
            return base.Get<Dictionary<string, object>>($"/{realm}/clients/{id}/optionalClientScopes");
        }
        public IObservable<RxHttpResponse> PutOptionalClientScope(string realm, string id, string clientScopeId)
        {
            return Put($"/{realm}/clients/{id}/optionalClientScopes/{clientScopeId}");
        }
        public IObservable<RxHttpResponse> DeleteOptionalClientScope(string realm, string id, string clientScopeId)
        {
            return Delete($"/{realm}/clients/{id}/optionalClientScopes/{clientScopeId}");
        }
        public IObservable<RxHttpResponse> PostClientProtocolMappersAddModels(ProtocolMapperRepresentation body, string realm, string id)
        {
            return base.Post($"/{realm}/clients/{id}/protocolMappers/addModels", body);
        }
        public IObservable<Dictionary<string, object>> GetClientProtocolMappersModels(string realm, string id)
        {
            return base.Get<Dictionary<string, object>>($"/{realm}/clients/{id}/protocolMappers/models");
        }
        public IObservable<RxHttpResponse> PostClientProtocolMappersModels(ProtocolMapperRepresentation body, string realm, string id)
        {
            return base.Post($"/{realm}/clients/{id}/protocolMappers/models", body);
        }
        public IObservable<Dictionary<string, object>> GetClientProtocolMappersProtocol(string realm, string id, string protocol)
        {
            return base.Get<Dictionary<string, object>>($"/{realm}/clients/{id}/protocolMappers/protocol/{protocol}");
        }
        public IObservable<GlobalRequestResult> PostClientPushRevocation(string realm, string id)
        {
            return base.Post<GlobalRequestResult>($"/{realm}/clients/{id}/pushRevocation");
        }
        public IObservable<ClientRepresentation> PostRegistrationAccessToken(string realm, string id)
        {
            return base.Post<ClientRepresentation>($"/{realm}/clients/{id}/registrationAccessToken");
        }
        public IObservable<Dictionary<string, object>> GetClientRoles(string briefRepresentation, string first, string max, string search, string realm, string id)
        {
            return base.Get<Dictionary<string, object>>($"/{realm}/clients/{id}/roles", null, options => {
                options.AddQueryString("briefRepresentation", briefRepresentation);
                options.AddQueryString("first", first);
                options.AddQueryString("max", max);
                options.AddQueryString("search", search);
            });
        }
        public IObservable<RxHttpResponse> PostClientRoles(RoleRepresentation body, string realm, string id)
        {
            return base.Post($"/{realm}/clients/{id}/roles", body);
        }
        public IObservable<RoleRepresentation> GetClientRole(string realm, string id, string roleName)
        {
            return base.Get<RoleRepresentation>($"/{realm}/clients/{id}/roles/{roleName}");
        }
        public IObservable<RxHttpResponse> PutClientRole(RoleRepresentation body, string realm, string id, string roleName)
        {
            return Put($"/{realm}/clients/{id}/roles/{roleName}", body);
        }
        public IObservable<RxHttpResponse> DeleteClientRole(string realm, string id, string roleName)
        {
            return Delete($"/{realm}/clients/{id}/roles/{roleName}");
        }
        public IObservable<Dictionary<string, object>> GetClientRoleComposites(string realm, string id, string roleName)
        {
            return base.Get<Dictionary<string, object>>($"/{realm}/clients/{id}/roles/{roleName}/composites");
        }
        public IObservable<RxHttpResponse> PostClientRoleComposites(RoleRepresentation body, string realm, string id, string roleName)
        {
            return base.Post($"/{realm}/clients/{id}/roles/{roleName}/composites", body);
        }
        public IObservable<RxHttpResponse> DeleteClientRoleComposites(RoleRepresentation body, string realm, string id, string roleName)
        {
            return Delete($"/{realm}/clients/{id}/roles/{roleName}/composites", body);
        }
        public IObservable<Dictionary<string, object>> GetClientRoleCompositesClient(string realm, string id, string roleName, string clientUuid)
        {
            return base.Get<Dictionary<string, object>>($"/{realm}/clients/{id}/roles/{roleName}/composites/clients/{clientUuid}");
        }
        public IObservable<Dictionary<string, object>> GetClientRoleCompositesRealm(string realm, string id, string roleName)
        {
            return base.Get<Dictionary<string, object>>($"/{realm}/clients/{id}/roles/{roleName}/composites/realm");
        }
        public IObservable<Dictionary<string, object>> GetClientRoleGroups(string briefRepresentation, string first, string max, string realm, string id, string roleName)
        {
            return base.Get<Dictionary<string, object>>($"/{realm}/clients/{id}/roles/{roleName}/groups", null, options => {
                options.AddQueryString("briefRepresentation", briefRepresentation);
                options.AddQueryString("first", first);
                options.AddQueryString("max", max);
            });
        }
        public IObservable<ManagementPermissionReference> GetClientRoleManagementPermissions(string realm, string id, string roleName)
        {
            return base.Get<ManagementPermissionReference>($"/{realm}/clients/{id}/roles/{roleName}/management/permissions");
        }
        public IObservable<ManagementPermissionReference> PutClientRoleManagementPermissions(ManagementPermissionReference body, string realm, string id, string roleName)
        {
            return Put<ManagementPermissionReference>($"/{realm}/clients/{id}/roles/{roleName}/management/permissions", body);
        }
        public IObservable<Dictionary<string, object>> GetClientRoleUsers(string first, string max, string realm, string id, string roleName)
        {
            return base.Get<Dictionary<string, object>>($"/{realm}/clients/{id}/roles/{roleName}/users", null, options => {
                options.AddQueryString("first", first);
                options.AddQueryString("max", max);
            });
        }
        public IObservable<MappingsRepresentation> GetClientScopeMappings(string realm, string id)
        {
            return base.Get<MappingsRepresentation>($"/{realm}/clients/{id}/scopeMappings");
        }
        public IObservable<Dictionary<string, object>> GetClientScopeMappingsClient(string realm, string id, string client)
        {
            return base.Get<Dictionary<string, object>>($"/{realm}/clients/{id}/scopeMappings/clients/{client}");
        }
        public IObservable<RxHttpResponse> PostClientScopeMappingsClient(RoleRepresentation body, string realm, string id, string client)
        {
            return base.Post($"/{realm}/clients/{id}/scopeMappings/clients/{client}", body);
        }
        public IObservable<RxHttpResponse> DeleteClientScopeMappingsClient(RoleRepresentation body, string realm, string id, string client)
        {
            return Delete($"/{realm}/clients/{id}/scopeMappings/clients/{client}", body);
        }
        public IObservable<Dictionary<string, object>> GetClientScopeMappingsClientAvailable(string realm, string id, string client)
        {
            return base.Get<Dictionary<string, object>>($"/{realm}/clients/{id}/scopeMappings/clients/{client}/available");
        }
        public IObservable<Dictionary<string, object>> GetClientScopeMappingsClientComposite(string briefRepresentation, string realm, string id, string client)
        {
            return base.Get<Dictionary<string, object>>($"/{realm}/clients/{id}/scopeMappings/clients/{client}/composite", null, options => {
                options.AddQueryString("briefRepresentation", briefRepresentation);
            });
        }
        public IObservable<Dictionary<string, object>> GetClientScopeMappingsRealm(string realm, string id)
        {
            return base.Get<Dictionary<string, object>>($"/{realm}/clients/{id}/scopeMappings/realm");
        }
        public IObservable<RxHttpResponse> PostClientScopeMappingsRealm(RoleRepresentation body, string realm, string id)
        {
            return base.Post($"/{realm}/clients/{id}/scopeMappings/realm", body);
        }
        public IObservable<RxHttpResponse> DeleteClientScopeMappingsRealm(RoleRepresentation body, string realm, string id)
        {
            return Delete($"/{realm}/clients/{id}/scopeMappings/realm", body);
        }
        public IObservable<Dictionary<string, object>> GetClientScopeMappingsRealmAvailable(string realm, string id)
        {
            return base.Get<Dictionary<string, object>>($"/{realm}/clients/{id}/scopeMappings/realm/available");
        }
        public IObservable<Dictionary<string, object>> GetClientScopeMappingsRealmComposite(string briefRepresentation, string realm, string id)
        {
            return base.Get<Dictionary<string, object>>($"/{realm}/clients/{id}/scopeMappings/realm/composite", null, options => {
                options.AddQueryString("briefRepresentation", briefRepresentation);
            });
        }
        public IObservable<UserRepresentation> GetServiceAccountUser(string realm, string id)
        {
            return base.Get<UserRepresentation>($"/{realm}/clients/{id}/serviceAccountUser");
        }
        public IObservable<Dictionary<string, object>> GetSessionCount(string realm, string id)
        {
            return base.Get<Dictionary<string, object>>($"/{realm}/clients/{id}/sessionCount");
        }
        public IObservable<GlobalRequestResult> GetTestNodesAvailable(string realm, string id)
        {
            return base.Get<GlobalRequestResult>($"/{realm}/clients/{id}/testNodesAvailable");
        }
        public IObservable<Dictionary<string, object>> GetClientUserSessions(string first, string max, string realm, string id)
        {
            return base.Get<Dictionary<string, object>>($"/{realm}/clients/{id}/userSessions", null, options => {
                options.AddQueryString("first", first);
                options.AddQueryString("max", max);
            });
        }
        public IObservable<Dictionary<string, object>> GetComponents(string name, string parent, string type, string realm)
        {
            return base.Get<Dictionary<string, object>>($"/{realm}/components", null, options => {
                options.AddQueryString("name", name);
                options.AddQueryString("parent", parent);
                options.AddQueryString("type", type);
            });
        }
        public IObservable<RxHttpResponse> PostComponents(ComponentRepresentation body, string realm)
        {
            return base.Post($"/{realm}/components", body);
        }
        public IObservable<ComponentRepresentation> GetComponent(string realm, string id)
        {
            return base.Get<ComponentRepresentation>($"/{realm}/components/{id}");
        }
        public IObservable<RxHttpResponse> PutComponent(ComponentRepresentation body, string realm, string id)
        {
            return Put($"/{realm}/components/{id}", body);
        }
        public IObservable<RxHttpResponse> DeleteComponent(string realm, string id)
        {
            return Delete($"/{realm}/components/{id}");
        }
        public IObservable<Dictionary<string, object>> GetSubComponentTypes(string type, string realm, string id)
        {
            return base.Get<Dictionary<string, object>>($"/{realm}/components/{id}/subComponentTypes", null, options => {
                options.AddQueryString("type", type);
            });
        }
        public IObservable<Dictionary<string, object>> GetCredentialRegistrators(string realm)
        {
            return base.Get<Dictionary<string, object>>($"/{realm}/credentialRegistrators");
        }
        public IObservable<Dictionary<string, object>> GetDefaultDefaultClientScopes(string realm)
        {
            return base.Get<Dictionary<string, object>>($"/{realm}/defaultDefaultClientScopes");
        }
        public IObservable<RxHttpResponse> PutDefaultDefaultClientScope(string realm, string clientScopeId)
        {
            return Put($"/{realm}/defaultDefaultClientScopes/{clientScopeId}");
        }
        public IObservable<RxHttpResponse> DeleteDefaultDefaultClientScope(string realm, string clientScopeId)
        {
            return Delete($"/{realm}/defaultDefaultClientScopes/{clientScopeId}");
        }
        public IObservable<Dictionary<string, object>> GetDefaultGroups(string realm)
        {
            return base.Get<Dictionary<string, object>>($"/{realm}/defaultGroups");
        }
        public IObservable<RxHttpResponse> PutDefaultGroup(string realm, string groupId)
        {
            return Put($"/{realm}/defaultGroups/{groupId}");
        }
        public IObservable<RxHttpResponse> DeleteDefaultGroup(string realm, string groupId)
        {
            return Delete($"/{realm}/defaultGroups/{groupId}");
        }
        public IObservable<Dictionary<string, object>> GetDefaultOptionalClientScopes(string realm)
        {
            return base.Get<Dictionary<string, object>>($"/{realm}/defaultOptionalClientScopes");
        }
        public IObservable<RxHttpResponse> PutDefaultOptionalClientScope(string realm, string clientScopeId)
        {
            return Put($"/{realm}/defaultOptionalClientScopes/{clientScopeId}");
        }
        public IObservable<RxHttpResponse> DeleteDefaultOptionalClientScope(string realm, string clientScopeId)
        {
            return Delete($"/{realm}/defaultOptionalClientScopes/{clientScopeId}");
        }
        public IObservable<Dictionary<string, object>> GetEvents(string client, string dateFrom, string dateTo, string first, string ipAddress, string max, string type, string user, string realm)
        {
            return base.Get<Dictionary<string, object>>($"/{realm}/events", null, options => {
                options.AddQueryString("client", client);
                options.AddQueryString("dateFrom", dateFrom);
                options.AddQueryString("dateTo", dateTo);
                options.AddQueryString("first", first);
                options.AddQueryString("ipAddress", ipAddress);
                options.AddQueryString("max", max);
                options.AddQueryString("type", type);
                options.AddQueryString("user", user);
            });
        }
        public IObservable<RxHttpResponse> DeleteEvents(string realm)
        {
            return Delete($"/{realm}/events");
        }
        public IObservable<RealmEventsConfigRepresentation> GetEventsConfig(string realm)
        {
            return base.Get<RealmEventsConfigRepresentation>($"/{realm}/events/config");
        }
        public IObservable<RxHttpResponse> PutEventsConfig(RealmEventsConfigRepresentation body, string realm)
        {
            return Put($"/{realm}/events/config", body);
        }
        public IObservable<GroupRepresentation> GetGroupByPath(string realm, string path)
        {
            return base.Get<GroupRepresentation>($"/{realm}/groupByPath/{path}");
        }
        public IObservable<Dictionary<string, object>> GetGroupsByRealm(string briefRepresentation, string exact, string first, string max, string populateHierarchy, string q, string search, string realm)
        {
            return base.Get<Dictionary<string, object>>($"/{realm}/groups", null, options => {
                options.AddQueryString("briefRepresentation", briefRepresentation);
                options.AddQueryString("exact", exact);
                options.AddQueryString("first", first);
                options.AddQueryString("max", max);
                options.AddQueryString("populateHierarchy", populateHierarchy);
                options.AddQueryString("q", q);
                options.AddQueryString("search", search);
            });
        }
        public IObservable<RxHttpResponse> PostGroups(GroupRepresentation body, string realm)
        {
            return base.Post($"/{realm}/groups", body);
        }
        public IObservable<Dictionary<string, object>> GetGroupsCountByRealm(string search, string top, string realm)
        {
            return base.Get<Dictionary<string, object>>($"/{realm}/groups/count", null, options => {
                options.AddQueryString("search", search);
                options.AddQueryString("top", top);
            });
        }
        public IObservable<GroupRepresentation> GetGroup(string realm, string id)
        {
            return base.Get<GroupRepresentation>($"/{realm}/groups/{id}");
        }
        public IObservable<RxHttpResponse> PutGroupByRealmById(GroupRepresentation body, string realm, string id)
        {
            return Put($"/{realm}/groups/{id}", body);
        }
        public IObservable<RxHttpResponse> DeleteGroupByRealmById(string realm, string id)
        {
            return Delete($"/{realm}/groups/{id}");
        }
        public IObservable<RxHttpResponse> PostChildren(GroupRepresentation body, string realm, string id)
        {
            return base.Post($"/{realm}/groups/{id}/children", body);
        }
        public IObservable<ManagementPermissionReference> GetGroupManagementPermissions(string realm, string id)
        {
            return base.Get<ManagementPermissionReference>($"/{realm}/groups/{id}/management/permissions");
        }
        public IObservable<ManagementPermissionReference> PutGroupManagementPermissions(ManagementPermissionReference body, string realm, string id)
        {
            return Put<ManagementPermissionReference>($"/{realm}/groups/{id}/management/permissions", body);
        }
        public IObservable<Dictionary<string, object>> GetMembers(string briefRepresentation, string first, string max, string realm, string id)
        {
            return base.Get<Dictionary<string, object>>($"/{realm}/groups/{id}/members", null, options => {
                options.AddQueryString("briefRepresentation", briefRepresentation);
                options.AddQueryString("first", first);
                options.AddQueryString("max", max);
            });
        }
        public IObservable<MappingsRepresentation> GetGroupRoleMappings(string realm, string id)
        {
            return base.Get<MappingsRepresentation>($"/{realm}/groups/{id}/roleMappings");
        }
        public IObservable<Dictionary<string, object>> GetGroupRoleMappingsClient(string realm, string id, string client)
        {
            return base.Get<Dictionary<string, object>>($"/{realm}/groups/{id}/roleMappings/clients/{client}");
        }
        public IObservable<RxHttpResponse> PostGroupRoleMappingsClient(RoleRepresentation body, string realm, string id, string client)
        {
            return base.Post($"/{realm}/groups/{id}/roleMappings/clients/{client}", body);
        }
        public IObservable<RxHttpResponse> DeleteGroupRoleMappingsClient(RoleRepresentation body, string realm, string id, string client)
        {
            return Delete($"/{realm}/groups/{id}/roleMappings/clients/{client}", body);
        }
        public IObservable<Dictionary<string, object>> GetGroupRoleMappingsClientAvailable(string realm, string id, string client)
        {
            return base.Get<Dictionary<string, object>>($"/{realm}/groups/{id}/roleMappings/clients/{client}/available");
        }
        public IObservable<Dictionary<string, object>> GetGroupRoleMappingsClientComposite(string briefRepresentation, string realm, string id, string client)
        {
            return base.Get<Dictionary<string, object>>($"/{realm}/groups/{id}/roleMappings/clients/{client}/composite", null, options => {
                options.AddQueryString("briefRepresentation", briefRepresentation);
            });
        }
        public IObservable<Dictionary<string, object>> GetGroupRoleMappingsRealm(string realm, string id)
        {
            return base.Get<Dictionary<string, object>>($"/{realm}/groups/{id}/roleMappings/realm");
        }
        public IObservable<RxHttpResponse> PostGroupRoleMappingsRealm(RoleRepresentation body, string realm, string id)
        {
            return base.Post($"/{realm}/groups/{id}/roleMappings/realm", body);
        }
        public IObservable<RxHttpResponse> DeleteGroupRoleMappingsRealm(RoleRepresentation body, string realm, string id)
        {
            return Delete($"/{realm}/groups/{id}/roleMappings/realm", body);
        }
        public IObservable<Dictionary<string, object>> GetGroupRoleMappingsRealmAvailable(string realm, string id)
        {
            return base.Get<Dictionary<string, object>>($"/{realm}/groups/{id}/roleMappings/realm/available");
        }
        public IObservable<Dictionary<string, object>> GetGroupRoleMappingsRealmComposite(string briefRepresentation, string realm, string id)
        {
            return base.Get<Dictionary<string, object>>($"/{realm}/groups/{id}/roleMappings/realm/composite", null, options => {
                options.AddQueryString("briefRepresentation", briefRepresentation);
            });
        }
        public IObservable<Dictionary<string, object>> PostImportConfig(Dictionary<string, object> body, string realm)
        {
            return base.Post<Dictionary<string, object>>($"/{realm}/identityProvider/importConfig", body);
        }
        public IObservable<Dictionary<string, object>> GetInstances(string realm)
        {
            return base.Get<Dictionary<string, object>>($"/{realm}/identityProvider/instances");
        }
        public IObservable<RxHttpResponse> PostInstances(IdentityProviderRepresentation body, string realm)
        {
            return base.Post($"/{realm}/identityProvider/instances", body);
        }
        public IObservable<IdentityProviderRepresentation> GetInstance(string realm, string alias)
        {
            return base.Get<IdentityProviderRepresentation>($"/{realm}/identityProvider/instances/{alias}");
        }
        public IObservable<RxHttpResponse> PutInstance(IdentityProviderRepresentation body, string realm, string alias)
        {
            return Put($"/{realm}/identityProvider/instances/{alias}", body);
        }
        public IObservable<RxHttpResponse> DeleteInstance(string realm, string alias)
        {
            return Delete($"/{realm}/identityProvider/instances/{alias}");
        }
        public IObservable<RxHttpResponse> GetExport(string format, string realm, string alias)
        {
            return base.Get($"/{realm}/identityProvider/instances/{alias}/export", null, options => {
                options.AddQueryString("format", format);
            });
        }
        public IObservable<ManagementPermissionReference> GetInstanceManagementPermissions(string realm, string alias)
        {
            return base.Get<ManagementPermissionReference>($"/{realm}/identityProvider/instances/{alias}/management/permissions");
        }
        public IObservable<ManagementPermissionReference> PutInstanceManagementPermissions(ManagementPermissionReference body, string realm, string alias)
        {
            return Put<ManagementPermissionReference>($"/{realm}/identityProvider/instances/{alias}/management/permissions", body);
        }
        public IObservable<RxHttpResponse> GetMapperTypes(string realm, string alias)
        {
            return base.Get($"/{realm}/identityProvider/instances/{alias}/mapperTypes");
        }
        public IObservable<Dictionary<string, object>> GetMappers(string realm, string alias)
        {
            return base.Get<Dictionary<string, object>>($"/{realm}/identityProvider/instances/{alias}/mappers");
        }
        public IObservable<RxHttpResponse> PostMappers(IdentityProviderMapperRepresentation body, string realm, string alias)
        {
            return base.Post($"/{realm}/identityProvider/instances/{alias}/mappers", body);
        }
        public IObservable<IdentityProviderMapperRepresentation> GetMapper(string realm, string alias, string id)
        {
            return base.Get<IdentityProviderMapperRepresentation>($"/{realm}/identityProvider/instances/{alias}/mappers/{id}");
        }
        public IObservable<RxHttpResponse> PutMapper(IdentityProviderMapperRepresentation body, string realm, string alias, string id)
        {
            return Put($"/{realm}/identityProvider/instances/{alias}/mappers/{id}", body);
        }
        public IObservable<RxHttpResponse> DeleteMapper(string realm, string alias, string id)
        {
            return Delete($"/{realm}/identityProvider/instances/{alias}/mappers/{id}");
        }
        public IObservable<RxHttpResponse> GetIdentityProviderProvider(string realm, string providerId)
        {
            return base.Get($"/{realm}/identityProvider/providers/{providerId}");
        }
        public IObservable<KeysMetadataRepresentation> GetKeys(string realm)
        {
            return base.Get<KeysMetadataRepresentation>($"/{realm}/keys");
        }
        public IObservable<Dictionary<string, object>> GetLocalizationByRealm(string realm)
        {
            return base.Get<Dictionary<string, object>>($"/{realm}/localization");
        }
        public IObservable<Dictionary<string, object>> GetLocalizationByRealmByLocale(string useRealmDefaultLocaleFallback, string realm, string locale)
        {
            return base.Get<Dictionary<string, object>>($"/{realm}/localization/{locale}", null, options => {
                options.AddQueryString("useRealmDefaultLocaleFallback", useRealmDefaultLocaleFallback);
            });
        }
        public IObservable<RxHttpResponse> PostLocalization(string body, string realm, string locale)
        {
            return base.Post($"/{realm}/localization/{locale}", body);
        }
        public IObservable<RxHttpResponse> DeleteLocalizationByRealmByLocale(string realm, string locale)
        {
            return Delete($"/{realm}/localization/{locale}");
        }
        public IObservable<RxHttpResponse> GetLocalizationByRealmByLocaleByKey(string realm, string locale, string key)
        {
            return base.Get($"/{realm}/localization/{locale}/{key}");
        }
        public IObservable<RxHttpResponse> PutLocalization(string body, string realm, string locale, string key)
        {
            return Put($"/{realm}/localization/{locale}/{key}", body);
        }
        public IObservable<RxHttpResponse> DeleteLocalizationByRealmByLocaleByKey(string realm, string locale, string key)
        {
            return Delete($"/{realm}/localization/{locale}/{key}");
        }
        public IObservable<GlobalRequestResult> PostLogoutAll(string realm)
        {
            return base.Post<GlobalRequestResult>($"/{realm}/logoutAll");
        }
        public IObservable<RxHttpResponse> PostPartialExport(string exportClients, string exportGroupsAndRoles, string realm)
        {
            return base.Post($"/{realm}/partialExport", null, options => {
                options.AddQueryString("exportClients", exportClients);
                options.AddQueryString("exportGroupsAndRoles", exportGroupsAndRoles);
            });
        }
        public IObservable<RxHttpResponse> PostPartialImport(string body, string realm)
        {
            return base.Post($"/{realm}/partialImport", body);
        }
        public IObservable<GlobalRequestResult> PostPushRevocationByRealm(string realm)
        {
            return base.Post<GlobalRequestResult>($"/{realm}/pushRevocation");
        }
        public IObservable<Dictionary<string, object>> GetRolesByRealm(string briefRepresentation, string first, string max, string search, string realm)
        {
            return base.Get<Dictionary<string, object>>($"/{realm}/roles", null, options => {
                options.AddQueryString("briefRepresentation", briefRepresentation);
                options.AddQueryString("first", first);
                options.AddQueryString("max", max);
                options.AddQueryString("search", search);
            });
        }
        public IObservable<RxHttpResponse> PostRolesByRealm(RoleRepresentation body, string realm)
        {
            return base.Post($"/{realm}/roles", body);
        }
        public IObservable<RoleRepresentation> GetRolesById(string realm, string roleId)
        {
            return base.Get<RoleRepresentation>($"/{realm}/rolesById/{roleId}");
        }
        public IObservable<RxHttpResponse> PutRolesById(RoleRepresentation body, string realm, string roleId)
        {
            return Put($"/{realm}/rolesById/{roleId}", body);
        }
        public IObservable<RxHttpResponse> DeleteRolesById(string realm, string roleId)
        {
            return Delete($"/{realm}/rolesById/{roleId}");
        }
        public IObservable<Dictionary<string, object>> GetRolesByIdComposites(string first, string max, string search, string realm, string roleId)
        {
            return base.Get<Dictionary<string, object>>($"/{realm}/rolesById/{roleId}/composites", null, options => {
                options.AddQueryString("first", first);
                options.AddQueryString("max", max);
                options.AddQueryString("search", search);
            });
        }
        public IObservable<RxHttpResponse> PostRolesByIdComposites(RoleRepresentation body, string realm, string roleId)
        {
            return base.Post($"/{realm}/rolesById/{roleId}/composites", body);
        }
        public IObservable<RxHttpResponse> DeleteRolesByIdComposites(RoleRepresentation body, string realm, string roleId)
        {
            return Delete($"/{realm}/rolesById/{roleId}/composites", body);
        }
        public IObservable<Dictionary<string, object>> GetRolesByIdCompositesClient(string realm, string roleId, string clientUuid)
        {
            return base.Get<Dictionary<string, object>>($"/{realm}/rolesById/{roleId}/composites/clients/{clientUuid}");
        }
        public IObservable<Dictionary<string, object>> GetRolesByIdCompositesRealm(string realm, string roleId)
        {
            return base.Get<Dictionary<string, object>>($"/{realm}/rolesById/{roleId}/composites/realm");
        }
        public IObservable<ManagementPermissionReference> GetRolesByIdManagementPermissions(string realm, string roleId)
        {
            return base.Get<ManagementPermissionReference>($"/{realm}/rolesById/{roleId}/management/permissions");
        }
        public IObservable<ManagementPermissionReference> PutRolesByIdManagementPermissions(ManagementPermissionReference body, string realm, string roleId)
        {
            return Put<ManagementPermissionReference>($"/{realm}/rolesById/{roleId}/management/permissions", body);
        }
        public IObservable<RoleRepresentation> GetRoleByRealmByRoleName(string realm, string roleName)
        {
            return base.Get<RoleRepresentation>($"/{realm}/roles/{roleName}");
        }
        public IObservable<RxHttpResponse> PutRoleByRealmByRoleName(RoleRepresentation body, string realm, string roleName)
        {
            return Put($"/{realm}/roles/{roleName}", body);
        }
        public IObservable<RxHttpResponse> DeleteRoleByRealmByRoleName(string realm, string roleName)
        {
            return Delete($"/{realm}/roles/{roleName}");
        }
        public IObservable<Dictionary<string, object>> GetRoleCompositesByRealmByRoleName(string realm, string roleName)
        {
            return base.Get<Dictionary<string, object>>($"/{realm}/roles/{roleName}/composites");
        }
        public IObservable<RxHttpResponse> PostRoleCompositesByRealmByRoleName(RoleRepresentation body, string realm, string roleName)
        {
            return base.Post($"/{realm}/roles/{roleName}/composites", body);
        }
        public IObservable<RxHttpResponse> DeleteRoleCompositesByRealmByRoleName(RoleRepresentation body, string realm, string roleName)
        {
            return Delete($"/{realm}/roles/{roleName}/composites", body);
        }
        public IObservable<Dictionary<string, object>> GetRoleCompositesClientByRealmByRoleNameByClientUuid(string realm, string roleName, string clientUuid)
        {
            return base.Get<Dictionary<string, object>>($"/{realm}/roles/{roleName}/composites/clients/{clientUuid}");
        }
        public IObservable<Dictionary<string, object>> GetRoleCompositesRealmByRealmByRoleName(string realm, string roleName)
        {
            return base.Get<Dictionary<string, object>>($"/{realm}/roles/{roleName}/composites/realm");
        }
        public IObservable<Dictionary<string, object>> GetRoleGroupsByRealmByRoleName(string briefRepresentation, string first, string max, string realm, string roleName)
        {
            return base.Get<Dictionary<string, object>>($"/{realm}/roles/{roleName}/groups", null, options => {
                options.AddQueryString("briefRepresentation", briefRepresentation);
                options.AddQueryString("first", first);
                options.AddQueryString("max", max);
            });
        }
        public IObservable<ManagementPermissionReference> GetRoleManagementPermissionsByRealmByRoleName(string realm, string roleName)
        {
            return base.Get<ManagementPermissionReference>($"/{realm}/roles/{roleName}/management/permissions");
        }
        public IObservable<ManagementPermissionReference> PutRoleManagementPermissionsByRealmByRoleName(ManagementPermissionReference body, string realm, string roleName)
        {
            return Put<ManagementPermissionReference>($"/{realm}/roles/{roleName}/management/permissions", body);
        }
        public IObservable<Dictionary<string, object>> GetRoleUsersByRealmByRoleName(string first, string max, string realm, string roleName)
        {
            return base.Get<Dictionary<string, object>>($"/{realm}/roles/{roleName}/users", null, options => {
                options.AddQueryString("first", first);
                options.AddQueryString("max", max);
            });
        }
        public IObservable<RxHttpResponse> DeleteSession(string realm, string session)
        {
            return Delete($"/{realm}/sessions/{session}");
        }
        public IObservable<RxHttpResponse> PostTestSmtpConnection(string body, string realm)
        {
            return base.Post($"/{realm}/testSMTPConnection", body);
        }
        public IObservable<Dictionary<string, object>> GetUsersByRealm(string briefRepresentation, string email, string emailVerified, string enabled, string exact, string first, string firstName, string idpAlias, string idpUserId, string lastName, string max, string q, string search, string username, string realm)
        {
            return base.Get<Dictionary<string, object>>($"/{realm}/users", null, options => {
                options.AddQueryString("briefRepresentation", briefRepresentation);
                options.AddQueryString("email", email);
                options.AddQueryString("emailVerified", emailVerified);
                options.AddQueryString("enabled", enabled);
                options.AddQueryString("exact", exact);
                options.AddQueryString("first", first);
                options.AddQueryString("firstName", firstName);
                options.AddQueryString("idpAlias", idpAlias);
                options.AddQueryString("idpUserId", idpUserId);
                options.AddQueryString("lastName", lastName);
                options.AddQueryString("max", max);
                options.AddQueryString("q", q);
                options.AddQueryString("search", search);
                options.AddQueryString("username", username);
            });
        }
        public IObservable<RxHttpResponse> PostUsers(UserRepresentation body, string realm)
        {
            return base.Post($"/{realm}/users", body);
        }
        public IObservable<ManagementPermissionReference> GetUsersManagementPermissions(string realm)
        {
            return base.Get<ManagementPermissionReference>($"/{realm}/usersManagementPermissions");
        }
        public IObservable<ManagementPermissionReference> PutUsersManagementPermissions(ManagementPermissionReference body, string realm)
        {
            return Put<ManagementPermissionReference>($"/{realm}/usersManagementPermissions", body);
        }
        public IObservable<int> GetUsersCount(string email, string emailVerified, string enabled, string firstName, string lastName, string q, string search, string username, string realm)
        {
            return base.Get<int>($"/{realm}/users/count", null, options => {
                options.AddQueryString("email", email);
                options.AddQueryString("emailVerified", emailVerified);
                options.AddQueryString("enabled", enabled);
                options.AddQueryString("firstName", firstName);
                options.AddQueryString("lastName", lastName);
                options.AddQueryString("q", q);
                options.AddQueryString("search", search);
                options.AddQueryString("username", username);
            });
        }
        public IObservable<string> GetProfile(string realm)
        {
            return base.Get<string>($"/{realm}/users/profile");
        }
        public IObservable<RxHttpResponse> PutProfile(string body, string realm)
        {
            return Put($"/{realm}/users/profile", body);
        }
        public IObservable<UserRepresentation> GetUserByRealmById(string realm, string id)
        {
            return base.Get<UserRepresentation>($"/{realm}/users/{id}");
        }
        public IObservable<RxHttpResponse> PutUser(UserRepresentation body, string realm, string id)
        {
            return Put($"/{realm}/users/{id}", body);
        }
        public IObservable<RxHttpResponse> DeleteUserByRealmById(string realm, string id)
        {
            return Delete($"/{realm}/users/{id}");
        }
        public IObservable<Dictionary<string, object>> GetConfiguredUserStorageCredentialTypes(string realm, string id)
        {
            return base.Get<Dictionary<string, object>>($"/{realm}/users/{id}/configuredUserStorageCredentialTypes");
        }
        public IObservable<Dictionary<string, object>> GetConsents(string realm, string id)
        {
            return base.Get<Dictionary<string, object>>($"/{realm}/users/{id}/consents");
        }
        public IObservable<RxHttpResponse> DeleteConsent(string realm, string id, string client)
        {
            return Delete($"/{realm}/users/{id}/consents/{client}");
        }
        public IObservable<Dictionary<string, object>> GetCredentials(string realm, string id)
        {
            return base.Get<Dictionary<string, object>>($"/{realm}/users/{id}/credentials");
        }
        public IObservable<RxHttpResponse> DeleteCredential(string realm, string id, string credentialId)
        {
            return Delete($"/{realm}/users/{id}/credentials/{credentialId}");
        }
        public IObservable<RxHttpResponse> PostMoveAfter(string realm, string id, string credentialId, string newPreviousCredentialId)
        {
            return base.Post($"/{realm}/users/{id}/credentials/{credentialId}/moveAfter/{newPreviousCredentialId}");
        }
        public IObservable<RxHttpResponse> PostMoveToFirst(string realm, string id, string credentialId)
        {
            return base.Post($"/{realm}/users/{id}/credentials/{credentialId}/moveToFirst");
        }
        public IObservable<RxHttpResponse> PutUserLabel(string body, string realm, string id, string credentialId)
        {
            return Put($"/{realm}/users/{id}/credentials/{credentialId}/userLabel", body);
        }
        public IObservable<RxHttpResponse> PutDisableCredentialTypes(string body, string realm, string id)
        {
            return Put($"/{realm}/users/{id}/disableCredentialTypes", body);
        }
        public IObservable<RxHttpResponse> PutExecuteActionsEmail(string body, string clientId, string lifespan, string redirectUri, string realm, string id)
        {
            return Put($"/{realm}/users/{id}/executeActionsEmail", body, options => {
                options.AddQueryString("client_id", clientId);
                options.AddQueryString("lifespan", lifespan);
                options.AddQueryString("redirect_uri", redirectUri);
            });
        }
        public IObservable<Dictionary<string, object>> GetFederatedIdentity(string realm, string id)
        {
            return base.Get<Dictionary<string, object>>($"/{realm}/users/{id}/federatedIdentity");
        }
        public IObservable<RxHttpResponse> PostFederatedIdentity(string realm, string id, string provider)
        {
            return base.Post($"/{realm}/users/{id}/federatedIdentity/{provider}");
        }
        public IObservable<RxHttpResponse> DeleteFederatedIdentity(string realm, string id, string provider)
        {
            return Delete($"/{realm}/users/{id}/federatedIdentity/{provider}");
        }
        public IObservable<Dictionary<string, object>> GetUserGroups(string briefRepresentation, string first, string max, string search, string realm, string id)
        {
            return base.Get<Dictionary<string, object>>($"/{realm}/users/{id}/groups", null, options => {
                options.AddQueryString("briefRepresentation", briefRepresentation);
                options.AddQueryString("first", first);
                options.AddQueryString("max", max);
                options.AddQueryString("search", search);
            });
        }
        public IObservable<Dictionary<string, object>> GetUserGroupsCount(string search, string realm, string id)
        {
            return base.Get<Dictionary<string, object>>($"/{realm}/users/{id}/groups/count", null, options => {
                options.AddQueryString("search", search);
            });
        }
        public IObservable<RxHttpResponse> PutUserGroup(string realm, string id, string groupId)
        {
            return Put($"/{realm}/users/{id}/groups/{groupId}");
        }
        public IObservable<RxHttpResponse> DeleteUserGroup(string realm, string id, string groupId)
        {
            return Delete($"/{realm}/users/{id}/groups/{groupId}");
        }
        public IObservable<Dictionary<string, object>> PostImpersonation(string realm, string id)
        {
            return base.Post<Dictionary<string, object>>($"/{realm}/users/{id}/impersonation");
        }
        public IObservable<RxHttpResponse> PostLogout(string realm, string id)
        {
            return base.Post($"/{realm}/users/{id}/logout");
        }
        public IObservable<Dictionary<string, object>> GetOfflineSession(string realm, string id, string clientUuid)
        {
            return base.Get<Dictionary<string, object>>($"/{realm}/users/{id}/offlineSessions/{clientUuid}");
        }
        public IObservable<RxHttpResponse> PutResetPassword(CredentialRepresentation body, string realm, string id)
        {
            return Put($"/{realm}/users/{id}/resetPassword", body);
        }
        public IObservable<RxHttpResponse> PutResetPasswordEmail(string clientId, string redirectUri, string realm, string id)
        {
            return Put($"/{realm}/users/{id}/resetPasswordEmail", null, options => {
                options.AddQueryString("client_id", clientId);
                options.AddQueryString("redirect_uri", redirectUri);
            });
        }
        public IObservable<MappingsRepresentation> GetUserRoleMappings(string realm, string id)
        {
            return base.Get<MappingsRepresentation>($"/{realm}/users/{id}/roleMappings");
        }
        public IObservable<Dictionary<string, object>> GetUserRoleMappingsClient(string realm, string id, string client)
        {
            return base.Get<Dictionary<string, object>>($"/{realm}/users/{id}/roleMappings/clients/{client}");
        }
        public IObservable<RxHttpResponse> PostUserRoleMappingsClient(RoleRepresentation body, string realm, string id, string client)
        {
            return base.Post($"/{realm}/users/{id}/roleMappings/clients/{client}", body);
        }
        public IObservable<RxHttpResponse> DeleteUserRoleMappingsClient(RoleRepresentation body, string realm, string id, string client)
        {
            return Delete($"/{realm}/users/{id}/roleMappings/clients/{client}", body);
        }
        public IObservable<Dictionary<string, object>> GetUserRoleMappingsClientAvailable(string realm, string id, string client)
        {
            return base.Get<Dictionary<string, object>>($"/{realm}/users/{id}/roleMappings/clients/{client}/available");
        }
        public IObservable<Dictionary<string, object>> GetUserRoleMappingsClientComposite(string briefRepresentation, string realm, string id, string client)
        {
            return base.Get<Dictionary<string, object>>($"/{realm}/users/{id}/roleMappings/clients/{client}/composite", null, options => {
                options.AddQueryString("briefRepresentation", briefRepresentation);
            });
        }
        public IObservable<Dictionary<string, object>> GetUserRoleMappingsRealm(string realm, string id)
        {
            return base.Get<Dictionary<string, object>>($"/{realm}/users/{id}/roleMappings/realm");
        }
        public IObservable<RxHttpResponse> PostUserRoleMappingsRealm(RoleRepresentation body, string realm, string id)
        {
            return base.Post($"/{realm}/users/{id}/roleMappings/realm", body);
        }
        public IObservable<RxHttpResponse> DeleteUserRoleMappingsRealm(RoleRepresentation body, string realm, string id)
        {
            return Delete($"/{realm}/users/{id}/roleMappings/realm", body);
        }
        public IObservable<Dictionary<string, object>> GetUserRoleMappingsRealmAvailable(string realm, string id)
        {
            return base.Get<Dictionary<string, object>>($"/{realm}/users/{id}/roleMappings/realm/available");
        }
        public IObservable<Dictionary<string, object>> GetUserRoleMappingsRealmComposite(string briefRepresentation, string realm, string id)
        {
            return base.Get<Dictionary<string, object>>($"/{realm}/users/{id}/roleMappings/realm/composite", null, options => {
                options.AddQueryString("briefRepresentation", briefRepresentation);
            });
        }
        public IObservable<RxHttpResponse> PutSendVerifyEmail(string clientId, string redirectUri, string realm, string id)
        {
            return Put($"/{realm}/users/{id}/sendVerifyEmail", null, options => {
                options.AddQueryString("client_id", clientId);
                options.AddQueryString("redirect_uri", redirectUri);
            });
        }
        public IObservable<Dictionary<string, object>> GetSessions(string realm, string id)
        {
            return base.Get<Dictionary<string, object>>($"/{realm}/users/{id}/sessions");
        }
    }
}
