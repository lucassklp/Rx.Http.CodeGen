using Newtonsoft.Json;

namespace DocuSign.Models
{
    public class UserDrilldownResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("site_id")]
        public int SiteId { get; set; }
        [JsonProperty("site_name")]
        public string SiteName { get; set; }
        [JsonProperty("user_name")]
        public string UserName { get; set; }
        [JsonProperty("first_name")]
        public string FirstName { get; set; }
        [JsonProperty("last_name")]
        public string LastName { get; set; }
        [JsonProperty("user_status")]
        public string UserStatus { get; set; }
        [JsonProperty("default_account_id")]
        public string DefaultAccountId { get; set; }
        [JsonProperty("default_account_name")]
        public string DefaultAccountName { get; set; }
        [JsonProperty("language_culture")]
        public string LanguageCulture { get; set; }
        [JsonProperty("selected_languages")]
        public string SelectedLanguages { get; set; }
        [JsonProperty("federated_status")]
        public string FederatedStatus { get; set; }
        [JsonProperty("is_organization_admin")]
        public bool IsOrganizationAdmin { get; set; }
        [JsonProperty("created_on")]
        public string CreatedOn { get; set; }
        [JsonProperty("last_login")]
        public string LastLogin { get; set; }
        [JsonProperty("memberships")]
        public List<MembershipResponse> Memberships { get; set; }
        [JsonProperty("identities")]
        public List<UserIdentityResponse> Identities { get; set; }
        [JsonProperty("device_verification_enabled")]
        public bool DeviceVerificationEnabled { get; set; }
    }
}
