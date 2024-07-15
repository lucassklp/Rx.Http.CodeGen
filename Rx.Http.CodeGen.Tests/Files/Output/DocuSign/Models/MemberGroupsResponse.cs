using Newtonsoft.Json;

namespace DocuSign.Models
{
    public class MemberGroupsResponse
    {
        [JsonProperty("groups")]
        public List<MemberGroupResponse> Groups { get; set; }
        [JsonProperty("paging")]
        public PagingResponseProperties Paging { get; set; }
    }
}
