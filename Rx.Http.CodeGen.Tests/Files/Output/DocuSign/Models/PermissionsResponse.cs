using Newtonsoft.Json;

namespace DocuSign.Models
{
    public class PermissionsResponse
    {
        [JsonProperty("permissions")]
        public List<PermissionProfileResponse> Permissions { get; set; }
    }
}
