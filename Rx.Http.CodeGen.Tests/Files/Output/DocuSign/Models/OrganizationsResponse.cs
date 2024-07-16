using Newtonsoft.Json;

namespace DocuSign.Models
{
    public class OrganizationsResponse
    {
        [JsonProperty("organizations")]
        public List<OrganizationResponse> Organizations { get; set; }
    }
}
