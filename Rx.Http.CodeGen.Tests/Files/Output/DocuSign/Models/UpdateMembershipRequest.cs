using Newtonsoft.Json;

namespace DocuSign.Models
{
    public class UpdateMembershipRequest
    {
        [JsonProperty("account_id")]
        public string AccountId { get; set; }
        [JsonProperty("permission_profile")]
        public PermissionProfileRequest PermissionProfile { get; set; }
        [JsonProperty("groups")]
        public List<GroupRequest> Groups { get; set; }
        [JsonProperty("company_name")]
        public string CompanyName { get; set; }
        [JsonProperty("job_title")]
        public string JobTitle { get; set; }
        [JsonProperty("send_activation")]
        public bool SendActivation { get; set; }
        [JsonProperty("access_code")]
        public string AccessCode { get; set; }
    }
}
