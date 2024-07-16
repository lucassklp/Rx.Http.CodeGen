using Newtonsoft.Json;

namespace Keycloak.Models
{
    public class UserRepresentation
    {
        [JsonProperty("self")]
        public string Self { get; set; }
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("origin")]
        public string Origin { get; set; }
        [JsonProperty("createdTimestamp")]
        public int CreatedTimestamp { get; set; }
        [JsonProperty("username")]
        public string Username { get; set; }
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }
        [JsonProperty("totp")]
        public bool Totp { get; set; }
        [JsonProperty("emailVerified")]
        public bool EmailVerified { get; set; }
        [JsonProperty("firstName")]
        public string FirstName { get; set; }
        [JsonProperty("lastName")]
        public string LastName { get; set; }
        [JsonProperty("email")]
        public string Email { get; set; }
        [JsonProperty("federationLink")]
        public string FederationLink { get; set; }
        [JsonProperty("serviceAccountClientId")]
        public string ServiceAccountClientId { get; set; }
        [JsonProperty("attributes")]
        public object Attributes { get; set; }
        [JsonProperty("credentials")]
        public List<CredentialRepresentation> Credentials { get; set; }
        [JsonProperty("disableableCredentialTypes")]
        public List<string> DisableableCredentialTypes { get; set; }
        [JsonProperty("requiredActions")]
        public List<string> RequiredActions { get; set; }
        [JsonProperty("federatedIdentities")]
        public List<FederatedIdentityRepresentation> FederatedIdentities { get; set; }
        [JsonProperty("realmRoles")]
        public List<string> RealmRoles { get; set; }
        [JsonProperty("clientRoles")]
        public object ClientRoles { get; set; }
        [JsonProperty("clientConsents")]
        public List<UserConsentRepresentation> ClientConsents { get; set; }
        [JsonProperty("notBefore")]
        public int NotBefore { get; set; }
        [JsonProperty("applicationRoles")]
        public object ApplicationRoles { get; set; }
        [JsonProperty("socialLinks")]
        public List<SocialLinkRepresentation> SocialLinks { get; set; }
        [JsonProperty("groups")]
        public List<string> Groups { get; set; }
        [JsonProperty("access")]
        public object Access { get; set; }
    }
}
