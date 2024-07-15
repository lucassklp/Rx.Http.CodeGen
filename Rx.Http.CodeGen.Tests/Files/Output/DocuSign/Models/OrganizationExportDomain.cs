using Newtonsoft.Json;

namespace DocuSign.Models
{
    public class OrganizationExportDomain
    {
        [JsonProperty("domain")]
        public string Domain { get; set; }
    }
}
