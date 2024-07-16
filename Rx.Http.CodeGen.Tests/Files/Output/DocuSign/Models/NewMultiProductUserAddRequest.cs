using Newtonsoft.Json;

namespace DocuSign.Models
{
    public class NewMultiProductUserAddRequest
    {
        [JsonProperty("product_permission_profiles")]
        public List<ProductPermissionProfileRequest> ProductPermissionProfiles { get; set; }
        [JsonProperty("ds_groups")]
        public List<DsGroupRequest> DsGroups { get; set; }
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
        [JsonProperty("access_code")]
        public string AccessCode { get; set; }
        [JsonProperty("federated_status")]
        public string FederatedStatus { get; set; }
        [JsonProperty("auto_activate_memberships")]
        public bool AutoActivateMemberships { get; set; }
    }
}
