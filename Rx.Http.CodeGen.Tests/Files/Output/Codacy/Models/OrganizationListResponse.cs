using Newtonsoft.Json;

namespace Codacy.Models
{
    public class OrganizationListResponse
    {
        [JsonProperty("pagination")]
        public PaginationInfo Pagination { get; set; }
        [JsonProperty("data")]
        public List<Organization> Data { get; set; }
    }
}
