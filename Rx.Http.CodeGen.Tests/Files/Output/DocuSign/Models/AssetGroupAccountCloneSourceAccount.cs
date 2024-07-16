using Newtonsoft.Json;

namespace DocuSign.Models
{
    public class AssetGroupAccountCloneSourceAccount
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("externalAccountId")]
        public int ExternalAccountId { get; set; }
        [JsonProperty("site")]
        public string Site { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
