using Newtonsoft.Json;

namespace DocuSign.Models
{
    public class OrganizationResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("default_account_id")]
        public string DefaultAccountId { get; set; }
        [JsonProperty("default_permission_profile_id")]
        public int DefaultPermissionProfileId { get; set; }
        [JsonProperty("created_on")]
        public string CreatedOn { get; set; }
        [JsonProperty("created_by")]
        public string CreatedBy { get; set; }
        [JsonProperty("last_modified_on")]
        public string LastModifiedOn { get; set; }
        [JsonProperty("last_modified_by")]
        public string LastModifiedBy { get; set; }
        [JsonProperty("accounts")]
        public List<OrganizationAccountResponse> Accounts { get; set; }
        [JsonProperty("users")]
        public List<OrganizationSimpleIdObject> Users { get; set; }
        [JsonProperty("reserved_domains")]
        public List<DomainResponse> ReservedDomains { get; set; }
        [JsonProperty("identity_providers")]
        public List<IdentityProvidersResponse> IdentityProviders { get; set; }
        [JsonProperty("links")]
        public List<LinkResponse> Links { get; set; }
    }
}
