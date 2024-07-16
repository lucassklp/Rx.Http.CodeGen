using Newtonsoft.Json;

namespace DocuSign.Models
{
    public class UpdateUserRequest
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("site_id")]
        public int SiteId { get; set; }
        [JsonProperty("user_name")]
        public string UserName { get; set; }
        [JsonProperty("first_name")]
        public string FirstName { get; set; }
        [JsonProperty("last_name")]
        public string LastName { get; set; }
        [JsonProperty("email")]
        public string Email { get; set; }
        [JsonProperty("default_account_id")]
        public string DefaultAccountId { get; set; }
        [JsonProperty("language_culture")]
        public string LanguageCulture { get; set; }
        [JsonProperty("selected_languages")]
        public string SelectedLanguages { get; set; }
        [JsonProperty("federated_status")]
        public string FederatedStatus { get; set; }
        [JsonProperty("force_password_change")]
        public bool ForcePasswordChange { get; set; }
        [JsonProperty("memberships")]
        public List<UpdateMembershipRequest> Memberships { get; set; }
        [JsonProperty("device_verification_enabled")]
        public bool DeviceVerificationEnabled { get; set; }
    }
}
