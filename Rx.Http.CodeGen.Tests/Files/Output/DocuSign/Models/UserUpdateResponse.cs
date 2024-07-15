using Newtonsoft.Json;

namespace DocuSign.Models
{
    public class UserUpdateResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("site_id")]
        public int SiteId { get; set; }
        [JsonProperty("email")]
        public string Email { get; set; }
        [JsonProperty("error_details")]
        public ErrorDetails ErrorDetails { get; set; }
    }
}
