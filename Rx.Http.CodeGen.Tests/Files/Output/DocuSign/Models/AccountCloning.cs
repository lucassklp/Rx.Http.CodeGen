using Newtonsoft.Json;

namespace DocuSign.Models
{
    public class AccountCloning
    {
        [JsonProperty("assetGroupAccounts")]
        public List<AssetGroupAccountResponse> AssetGroupAccounts { get; set; }
    }
}
