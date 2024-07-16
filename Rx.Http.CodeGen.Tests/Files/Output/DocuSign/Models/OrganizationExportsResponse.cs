using Newtonsoft.Json;

namespace DocuSign.Models
{
    public class OrganizationExportsResponse
    {
        [JsonProperty("exports")]
        public List<OrganizationExportResponse> Exports { get; set; }
    }
}
