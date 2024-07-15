using Newtonsoft.Json;

namespace DocuSign.Models
{
    public class ForceActivateMembershipRequest
    {
        [JsonProperty("site_id")]
        public int SiteId { get; set; }
    }
}
