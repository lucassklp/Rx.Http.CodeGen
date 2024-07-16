using Newtonsoft.Json;

namespace DocuSign.Models
{
    public class AssetGroupAccountResponse
    {
        [JsonProperty("assetGroupId")]
        public string AssetGroupId { get; set; }
        [JsonProperty("assetGroupName")]
        public string AssetGroupName { get; set; }
        [JsonProperty("accountId")]
        public string AccountId { get; set; }
        [JsonProperty("accountName")]
        public string AccountName { get; set; }
        [JsonProperty("externalAccountId")]
        public int ExternalAccountId { get; set; }
        [JsonProperty("compliant")]
        public bool Compliant { get; set; }
        [JsonProperty("siteId")]
        public int SiteId { get; set; }
        [JsonProperty("siteName")]
        public string SiteName { get; set; }
    }
}
