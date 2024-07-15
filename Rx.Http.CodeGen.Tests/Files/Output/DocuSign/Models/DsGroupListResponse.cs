using Newtonsoft.Json;

namespace DocuSign.Models
{
    public class DsGroupListResponse
    {
        [JsonProperty("page")]
        public int Page { get; set; }
        [JsonProperty("page_size")]
        public int PageSize { get; set; }
        [JsonProperty("total_count")]
        public int TotalCount { get; set; }
        [JsonProperty("account_id")]
        public string AccountId { get; set; }
        [JsonProperty("ds_groups")]
        public List<DsGroupResponse> DsGroups { get; set; }
    }
}
