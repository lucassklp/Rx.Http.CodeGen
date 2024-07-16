using Newtonsoft.Json;

namespace DocuSign.Models
{
    public class AssetGroupAccountClones
    {
        [JsonProperty("assetGroupWorks")]
        public List<AssetGroupAccountClone> AssetGroupWorks { get; set; }
    }
}
