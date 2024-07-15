using Newtonsoft.Json;

namespace DocuSign.Models
{
    public class NewUserRequestAccountProperties
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("permission_profile")]
        public PermissionProfileRequest PermissionProfile { get; set; }
        [JsonProperty("groups")]
        public List<GroupRequest> Groups { get; set; }
        [JsonProperty("company_name")]
        public string CompanyName { get; set; }
        [JsonProperty("job_title")]
        public string JobTitle { get; set; }
    }
}
