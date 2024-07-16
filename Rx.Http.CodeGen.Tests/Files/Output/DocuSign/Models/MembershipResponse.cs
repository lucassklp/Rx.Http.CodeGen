using Newtonsoft.Json;

namespace DocuSign.Models
{
    public class MembershipResponse
    {
        [JsonProperty("email")]
        public string Email { get; set; }
        [JsonProperty("account_id")]
        public string AccountId { get; set; }
        [JsonProperty("external_account_id")]
        public string ExternalAccountId { get; set; }
        [JsonProperty("account_name")]
        public string AccountName { get; set; }
        [JsonProperty("is_external_account")]
        public bool IsExternalAccount { get; set; }
        [JsonProperty("status")]
        public string Status { get; set; }
        [JsonProperty("permission_profile")]
        public PermissionProfileResponse PermissionProfile { get; set; }
        [JsonProperty("created_on")]
        public string CreatedOn { get; set; }
        [JsonProperty("groups")]
        public List<MemberGroupResponse> Groups { get; set; }
        [JsonProperty("is_admin")]
        public bool IsAdmin { get; set; }
    }
}
