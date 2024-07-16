using Newtonsoft.Json;

namespace DocuSign.Models
{
    public class OrganizationUsersResponse
    {
        [JsonProperty("users")]
        public List<OrganizationUserResponse> Users { get; set; }
        [JsonProperty("paging")]
        public PagingResponseProperties Paging { get; set; }
    }
}
