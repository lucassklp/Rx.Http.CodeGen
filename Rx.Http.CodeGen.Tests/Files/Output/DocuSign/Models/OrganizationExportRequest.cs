using Newtonsoft.Json;

namespace DocuSign.Models
{
    public class OrganizationExportRequest
    {
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("accounts")]
        public List<OrganizationExportAccount> Accounts { get; set; }
        [JsonProperty("domains")]
        public List<OrganizationExportDomain> Domains { get; set; }
    }
}
