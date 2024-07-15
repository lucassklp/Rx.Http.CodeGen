using Newtonsoft.Json;

namespace Keycloak.Models
{
    public class RealmRepresentation
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("realm")]
        public string Realm { get; set; }
        [JsonProperty("displayName")]
        public string DisplayName { get; set; }
        [JsonProperty("displayNameHtml")]
        public string DisplayNameHtml { get; set; }
        [JsonProperty("notBefore")]
        public int NotBefore { get; set; }
        [JsonProperty("defaultSignatureAlgorithm")]
        public string DefaultSignatureAlgorithm { get; set; }
        [JsonProperty("revokeRefreshToken")]
        public bool RevokeRefreshToken { get; set; }
        [JsonProperty("refreshTokenMaxReuse")]
        public int RefreshTokenMaxReuse { get; set; }
        [JsonProperty("accessTokenLifespan")]
        public int AccessTokenLifespan { get; set; }
        [JsonProperty("accessTokenLifespanForImplicitFlow")]
        public int AccessTokenLifespanForImplicitFlow { get; set; }
        [JsonProperty("ssoSessionIdleTimeout")]
        public int SsoSessionIdleTimeout { get; set; }
        [JsonProperty("ssoSessionMaxLifespan")]
        public int SsoSessionMaxLifespan { get; set; }
        [JsonProperty("ssoSessionIdleTimeoutRememberMe")]
        public int SsoSessionIdleTimeoutRememberMe { get; set; }
        [JsonProperty("ssoSessionMaxLifespanRememberMe")]
        public int SsoSessionMaxLifespanRememberMe { get; set; }
        [JsonProperty("offlineSessionIdleTimeout")]
        public int OfflineSessionIdleTimeout { get; set; }
        [JsonProperty("offlineSessionMaxLifespanEnabled")]
        public bool OfflineSessionMaxLifespanEnabled { get; set; }
        [JsonProperty("offlineSessionMaxLifespan")]
        public int OfflineSessionMaxLifespan { get; set; }
        [JsonProperty("clientSessionIdleTimeout")]
        public int ClientSessionIdleTimeout { get; set; }
        [JsonProperty("clientSessionMaxLifespan")]
        public int ClientSessionMaxLifespan { get; set; }
        [JsonProperty("clientOfflineSessionIdleTimeout")]
        public int ClientOfflineSessionIdleTimeout { get; set; }
        [JsonProperty("clientOfflineSessionMaxLifespan")]
        public int ClientOfflineSessionMaxLifespan { get; set; }
        [JsonProperty("accessCodeLifespan")]
        public int AccessCodeLifespan { get; set; }
        [JsonProperty("accessCodeLifespanUserAction")]
        public int AccessCodeLifespanUserAction { get; set; }
        [JsonProperty("accessCodeLifespanLogin")]
        public int AccessCodeLifespanLogin { get; set; }
        [JsonProperty("actionTokenGeneratedByAdminLifespan")]
        public int ActionTokenGeneratedByAdminLifespan { get; set; }
        [JsonProperty("actionTokenGeneratedByUserLifespan")]
        public int ActionTokenGeneratedByUserLifespan { get; set; }
        [JsonProperty("oauth2DeviceCodeLifespan")]
        public int Oauth2DeviceCodeLifespan { get; set; }
        [JsonProperty("oauth2DevicePollingInterval")]
        public int Oauth2DevicePollingInterval { get; set; }
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }
        [JsonProperty("sslRequired")]
        public string SslRequired { get; set; }
        [JsonProperty("passwordCredentialGrantAllowed")]
        public bool PasswordCredentialGrantAllowed { get; set; }
        [JsonProperty("registrationAllowed")]
        public bool RegistrationAllowed { get; set; }
        [JsonProperty("registrationEmailAsUsername")]
        public bool RegistrationEmailAsUsername { get; set; }
        [JsonProperty("rememberMe")]
        public bool RememberMe { get; set; }
        [JsonProperty("verifyEmail")]
        public bool VerifyEmail { get; set; }
        [JsonProperty("loginWithEmailAllowed")]
        public bool LoginWithEmailAllowed { get; set; }
        [JsonProperty("duplicateEmailsAllowed")]
        public bool DuplicateEmailsAllowed { get; set; }
        [JsonProperty("resetPasswordAllowed")]
        public bool ResetPasswordAllowed { get; set; }
        [JsonProperty("editUsernameAllowed")]
        public bool EditUsernameAllowed { get; set; }
        [JsonProperty("userCacheEnabled")]
        public bool UserCacheEnabled { get; set; }
        [JsonProperty("realmCacheEnabled")]
        public bool RealmCacheEnabled { get; set; }
        [JsonProperty("bruteForceProtected")]
        public bool BruteForceProtected { get; set; }
        [JsonProperty("permanentLockout")]
        public bool PermanentLockout { get; set; }
        [JsonProperty("maxFailureWaitSeconds")]
        public int MaxFailureWaitSeconds { get; set; }
        [JsonProperty("minimumQuickLoginWaitSeconds")]
        public int MinimumQuickLoginWaitSeconds { get; set; }
        [JsonProperty("waitIncrementSeconds")]
        public int WaitIncrementSeconds { get; set; }
        [JsonProperty("quickLoginCheckMilliSeconds")]
        public int QuickLoginCheckMilliSeconds { get; set; }
        [JsonProperty("maxDeltaTimeSeconds")]
        public int MaxDeltaTimeSeconds { get; set; }
        [JsonProperty("failureFactor")]
        public int FailureFactor { get; set; }
        [JsonProperty("privateKey")]
        public string PrivateKey { get; set; }
        [JsonProperty("publicKey")]
        public string PublicKey { get; set; }
        [JsonProperty("certificate")]
        public string Certificate { get; set; }
        [JsonProperty("codeSecret")]
        public string CodeSecret { get; set; }
        [JsonProperty("roles")]
        public RolesRepresentation Roles { get; set; }
        [JsonProperty("groups")]
        public List<GroupRepresentation> Groups { get; set; }
        [JsonProperty("defaultRoles")]
        public List<string> DefaultRoles { get; set; }
        [JsonProperty("defaultRole")]
        public RoleRepresentation DefaultRole { get; set; }
        [JsonProperty("defaultGroups")]
        public List<string> DefaultGroups { get; set; }
        [JsonProperty("requiredCredentials")]
        public List<string> RequiredCredentials { get; set; }
        [JsonProperty("passwordPolicy")]
        public string PasswordPolicy { get; set; }
        [JsonProperty("otpPolicyType")]
        public string OtpPolicyType { get; set; }
        [JsonProperty("otpPolicyAlgorithm")]
        public string OtpPolicyAlgorithm { get; set; }
        [JsonProperty("otpPolicyInitialCounter")]
        public int OtpPolicyInitialCounter { get; set; }
        [JsonProperty("otpPolicyDigits")]
        public int OtpPolicyDigits { get; set; }
        [JsonProperty("otpPolicyLookAheadWindow")]
        public int OtpPolicyLookAheadWindow { get; set; }
        [JsonProperty("otpPolicyPeriod")]
        public int OtpPolicyPeriod { get; set; }
        [JsonProperty("otpPolicyCodeReusable")]
        public bool OtpPolicyCodeReusable { get; set; }
        [JsonProperty("otpSupportedApplications")]
        public List<string> OtpSupportedApplications { get; set; }
        [JsonProperty("webAuthnPolicyRpEntityName")]
        public string WebAuthnPolicyRpEntityName { get; set; }
        [JsonProperty("webAuthnPolicySignatureAlgorithms")]
        public List<string> WebAuthnPolicySignatureAlgorithms { get; set; }
        [JsonProperty("webAuthnPolicyRpId")]
        public string WebAuthnPolicyRpId { get; set; }
        [JsonProperty("webAuthnPolicyAttestationConveyancePreference")]
        public string WebAuthnPolicyAttestationConveyancePreference { get; set; }
        [JsonProperty("webAuthnPolicyAuthenticatorAttachment")]
        public string WebAuthnPolicyAuthenticatorAttachment { get; set; }
        [JsonProperty("webAuthnPolicyRequireResidentKey")]
        public string WebAuthnPolicyRequireResidentKey { get; set; }
        [JsonProperty("webAuthnPolicyUserVerificationRequirement")]
        public string WebAuthnPolicyUserVerificationRequirement { get; set; }
        [JsonProperty("webAuthnPolicyCreateTimeout")]
        public int WebAuthnPolicyCreateTimeout { get; set; }
        [JsonProperty("webAuthnPolicyAvoidSameAuthenticatorRegister")]
        public bool WebAuthnPolicyAvoidSameAuthenticatorRegister { get; set; }
        [JsonProperty("webAuthnPolicyAcceptableAaguids")]
        public List<string> WebAuthnPolicyAcceptableAaguids { get; set; }
        [JsonProperty("webAuthnPolicyPasswordlessRpEntityName")]
        public string WebAuthnPolicyPasswordlessRpEntityName { get; set; }
        [JsonProperty("webAuthnPolicyPasswordlessSignatureAlgorithms")]
        public List<string> WebAuthnPolicyPasswordlessSignatureAlgorithms { get; set; }
        [JsonProperty("webAuthnPolicyPasswordlessRpId")]
        public string WebAuthnPolicyPasswordlessRpId { get; set; }
        [JsonProperty("webAuthnPolicyPasswordlessAttestationConveyancePreference")]
        public string WebAuthnPolicyPasswordlessAttestationConveyancePreference { get; set; }
        [JsonProperty("webAuthnPolicyPasswordlessAuthenticatorAttachment")]
        public string WebAuthnPolicyPasswordlessAuthenticatorAttachment { get; set; }
        [JsonProperty("webAuthnPolicyPasswordlessRequireResidentKey")]
        public string WebAuthnPolicyPasswordlessRequireResidentKey { get; set; }
        [JsonProperty("webAuthnPolicyPasswordlessUserVerificationRequirement")]
        public string WebAuthnPolicyPasswordlessUserVerificationRequirement { get; set; }
        [JsonProperty("webAuthnPolicyPasswordlessCreateTimeout")]
        public int WebAuthnPolicyPasswordlessCreateTimeout { get; set; }
        [JsonProperty("webAuthnPolicyPasswordlessAvoidSameAuthenticatorRegister")]
        public bool WebAuthnPolicyPasswordlessAvoidSameAuthenticatorRegister { get; set; }
        [JsonProperty("webAuthnPolicyPasswordlessAcceptableAaguids")]
        public List<string> WebAuthnPolicyPasswordlessAcceptableAaguids { get; set; }
        [JsonProperty("clientProfiles")]
        public List<object> ClientProfiles { get; set; }
        [JsonProperty("clientPolicies")]
        public List<object> ClientPolicies { get; set; }
        [JsonProperty("users")]
        public List<UserRepresentation> Users { get; set; }
        [JsonProperty("federatedUsers")]
        public List<UserRepresentation> FederatedUsers { get; set; }
        [JsonProperty("scopeMappings")]
        public List<ScopeMappingRepresentation> ScopeMappings { get; set; }
        [JsonProperty("clientScopeMappings")]
        public object ClientScopeMappings { get; set; }
        [JsonProperty("clients")]
        public List<ClientRepresentation> Clients { get; set; }
        [JsonProperty("clientScopes")]
        public List<ClientScopeRepresentation> ClientScopes { get; set; }
        [JsonProperty("defaultDefaultClientScopes")]
        public List<string> DefaultDefaultClientScopes { get; set; }
        [JsonProperty("defaultOptionalClientScopes")]
        public List<string> DefaultOptionalClientScopes { get; set; }
        [JsonProperty("browserSecurityHeaders")]
        public object BrowserSecurityHeaders { get; set; }
        [JsonProperty("smtpServer")]
        public object SmtpServer { get; set; }
        [JsonProperty("userFederationProviders")]
        public List<UserFederationProviderRepresentation> UserFederationProviders { get; set; }
        [JsonProperty("userFederationMappers")]
        public List<UserFederationMapperRepresentation> UserFederationMappers { get; set; }
        [JsonProperty("loginTheme")]
        public string LoginTheme { get; set; }
        [JsonProperty("accountTheme")]
        public string AccountTheme { get; set; }
        [JsonProperty("adminTheme")]
        public string AdminTheme { get; set; }
        [JsonProperty("emailTheme")]
        public string EmailTheme { get; set; }
        [JsonProperty("eventsEnabled")]
        public bool EventsEnabled { get; set; }
        [JsonProperty("eventsExpiration")]
        public int EventsExpiration { get; set; }
        [JsonProperty("eventsListeners")]
        public List<string> EventsListeners { get; set; }
        [JsonProperty("enabledEventTypes")]
        public List<string> EnabledEventTypes { get; set; }
        [JsonProperty("adminEventsEnabled")]
        public bool AdminEventsEnabled { get; set; }
        [JsonProperty("adminEventsDetailsEnabled")]
        public bool AdminEventsDetailsEnabled { get; set; }
        [JsonProperty("identityProviders")]
        public List<IdentityProviderRepresentation> IdentityProviders { get; set; }
        [JsonProperty("identityProviderMappers")]
        public List<IdentityProviderMapperRepresentation> IdentityProviderMappers { get; set; }
        [JsonProperty("protocolMappers")]
        public List<ProtocolMapperRepresentation> ProtocolMappers { get; set; }
        [JsonProperty("components")]
        public object Components { get; set; }
        [JsonProperty("internationalizationEnabled")]
        public bool InternationalizationEnabled { get; set; }
        [JsonProperty("supportedLocales")]
        public List<string> SupportedLocales { get; set; }
        [JsonProperty("defaultLocale")]
        public string DefaultLocale { get; set; }
        [JsonProperty("authenticationFlows")]
        public List<AuthenticationFlowRepresentation> AuthenticationFlows { get; set; }
        [JsonProperty("authenticatorConfig")]
        public List<AuthenticatorConfigRepresentation> AuthenticatorConfig { get; set; }
        [JsonProperty("requiredActions")]
        public List<RequiredActionProviderRepresentation> RequiredActions { get; set; }
        [JsonProperty("browserFlow")]
        public string BrowserFlow { get; set; }
        [JsonProperty("registrationFlow")]
        public string RegistrationFlow { get; set; }
        [JsonProperty("directGrantFlow")]
        public string DirectGrantFlow { get; set; }
        [JsonProperty("resetCredentialsFlow")]
        public string ResetCredentialsFlow { get; set; }
        [JsonProperty("clientAuthenticationFlow")]
        public string ClientAuthenticationFlow { get; set; }
        [JsonProperty("dockerAuthenticationFlow")]
        public string DockerAuthenticationFlow { get; set; }
        [JsonProperty("attributes")]
        public object Attributes { get; set; }
        [JsonProperty("keycloakVersion")]
        public string KeycloakVersion { get; set; }
        [JsonProperty("userManagedAccessAllowed")]
        public bool UserManagedAccessAllowed { get; set; }
        [JsonProperty("social")]
        public bool Social { get; set; }
        [JsonProperty("updateProfileOnInitialSocialLogin")]
        public bool UpdateProfileOnInitialSocialLogin { get; set; }
        [JsonProperty("socialProviders")]
        public object SocialProviders { get; set; }
        [JsonProperty("applicationScopeMappings")]
        public object ApplicationScopeMappings { get; set; }
        [JsonProperty("applications")]
        public List<ApplicationRepresentation> Applications { get; set; }
        [JsonProperty("oauthClients")]
        public List<OAuthClientRepresentation> OauthClients { get; set; }
        [JsonProperty("clientTemplates")]
        public List<ClientTemplateRepresentation> ClientTemplates { get; set; }
        [JsonProperty("oAuth2DeviceCodeLifespan")]
        public int OAuth2DeviceCodeLifespan { get; set; }
        [JsonProperty("oAuth2DevicePollingInterval")]
        public int OAuth2DevicePollingInterval { get; set; }
    }
}
