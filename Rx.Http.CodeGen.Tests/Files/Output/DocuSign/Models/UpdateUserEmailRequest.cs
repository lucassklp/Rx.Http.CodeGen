using Newtonsoft.Json;

namespace DocuSign.Models
{
    public class UpdateUserEmailRequest
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("site_id")]
        public int SiteId { get; set; }
        [JsonProperty("email")]
        public string Email { get; set; }
    }
}
