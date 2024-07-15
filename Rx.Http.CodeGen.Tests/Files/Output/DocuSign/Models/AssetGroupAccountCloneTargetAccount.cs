using Newtonsoft.Json;

namespace DocuSign.Models
{
    public class AssetGroupAccountCloneTargetAccount
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("region")]
        public string Region { get; set; }
        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }
        [JsonProperty("site")]
        public string Site { get; set; }
        [JsonProperty("admin")]
        public AssetGroupAccountCloneTargetAccountAdmin Admin { get; set; }
    }
}
