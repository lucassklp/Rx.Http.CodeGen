using Newtonsoft.Json;

namespace DocuSign.Models
{
    public class PermissionProfileResponse21
    {
        [JsonProperty("permission_profile_id")]
        public string PermissionProfileId { get; set; }
        [JsonProperty("permission_profile_name")]
        public string PermissionProfileName { get; set; }
    }
}
