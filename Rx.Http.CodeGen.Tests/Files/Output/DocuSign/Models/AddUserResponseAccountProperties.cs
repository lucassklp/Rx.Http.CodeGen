using Newtonsoft.Json;

namespace DocuSign.Models
{
    public class AddUserResponseAccountProperties
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("site_id")]
        public int SiteId { get; set; }
        [JsonProperty("product_permission_profiles")]
        public List<ProductPermissionProfileResponse> ProductPermissionProfiles { get; set; }
        [JsonProperty("ds_groups")]
        public List<DsGroupResponse> DsGroups { get; set; }
        [JsonProperty("company_name")]
        public string CompanyName { get; set; }
        [JsonProperty("job_title")]
        public string JobTitle { get; set; }
    }
}
