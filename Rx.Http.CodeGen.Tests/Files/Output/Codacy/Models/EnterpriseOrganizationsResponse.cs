using Newtonsoft.Json;

namespace Codacy.Models
{
    public class EnterpriseOrganizationsResponse
    {
        [JsonProperty("pagination")]
        public PaginationInfo Pagination { get; set; }
        [JsonProperty("data")]
        public List<EnterpriseOrganization> Data { get; set; }
    }
}
