using Newtonsoft.Json;

namespace DocuSign.Models
{
    public class DsGroupResponse
    {
        [JsonProperty("ds_group_id")]
        public string DsGroupId { get; set; }
        [JsonProperty("account_id")]
        public string AccountId { get; set; }
        [JsonProperty("source_product_name")]
        public string SourceProductName { get; set; }
        [JsonProperty("group_id")]
        public string GroupId { get; set; }
        [JsonProperty("group_name")]
        public string GroupName { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("is_admin")]
        public bool IsAdmin { get; set; }
        [JsonProperty("last_modified_on")]
        public string LastModifiedOn { get; set; }
        [JsonProperty("user_count")]
        public int UserCount { get; set; }
        [JsonProperty("external_account_id")]
        public int ExternalAccountId { get; set; }
        [JsonProperty("account_name")]
        public string AccountName { get; set; }
    }
}
