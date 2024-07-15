using Newtonsoft.Json;

namespace DocuSign.Models
{
    public class NewUserResponseAccountProperties
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("site_id")]
        public int SiteId { get; set; }
        [JsonProperty("permission_profile")]
        public PermissionProfileResponse PermissionProfile { get; set; }
        [JsonProperty("groups")]
        public List<MemberGroupResponse> Groups { get; set; }
        [JsonProperty("company_name")]
        public string CompanyName { get; set; }
        [JsonProperty("job_title")]
        public string JobTitle { get; set; }
    }
}
