using Newtonsoft.Json;

namespace DocuSign.Models
{
    public class DsGroupUsersResponse
    {
        [JsonProperty("page")]
        public int Page { get; set; }
        [JsonProperty("page_size")]
        public int PageSize { get; set; }
        [JsonProperty("total_count")]
        public int TotalCount { get; set; }
        [JsonProperty("users")]
        public List<DsGroupUserResponse> Users { get; set; }
    }
}
