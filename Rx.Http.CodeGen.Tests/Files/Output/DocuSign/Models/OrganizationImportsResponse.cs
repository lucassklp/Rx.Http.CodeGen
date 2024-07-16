using Newtonsoft.Json;

namespace DocuSign.Models
{
    public class OrganizationImportsResponse
    {
        [JsonProperty("imports")]
        public List<OrganizationImportResponse> Imports { get; set; }
    }
}
