using Newtonsoft.Json;

namespace DocuSign.Models
{
    public class OrganizationAccountResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("external_account_id")]
        public int ExternalAccountId { get; set; }
        [JsonProperty("site_id")]
        public int SiteId { get; set; }
    }
}
