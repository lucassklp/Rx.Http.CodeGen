using Newtonsoft.Json;

namespace DocuSign.Models
{
    public class AssetGroupAccountsResponse
    {
        [JsonProperty("assetGroupAccounts")]
        public List<AssetGroupAccountResponse> AssetGroupAccounts { get; set; }
    }
}
