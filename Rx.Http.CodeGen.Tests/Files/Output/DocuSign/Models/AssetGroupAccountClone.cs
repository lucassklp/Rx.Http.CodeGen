using Newtonsoft.Json;

namespace DocuSign.Models
{
    public class AssetGroupAccountClone
    {
        [JsonProperty("sourceAccount")]
        public AssetGroupAccountCloneSourceAccount SourceAccount { get; set; }
        [JsonProperty("targetAccount")]
        public AssetGroupAccountCloneTargetAccount TargetAccount { get; set; }
        [JsonProperty("assetGroupWorkId")]
        public string AssetGroupWorkId { get; set; }
        [JsonProperty("assetGroupId")]
        public string AssetGroupId { get; set; }
        [JsonProperty("assetGroupWorkType")]
        public string AssetGroupWorkType { get; set; }
        [JsonProperty("status")]
        public string Status { get; set; }
        [JsonProperty("cloneRequestId")]
        public string CloneRequestId { get; set; }
        [JsonProperty("orderId")]
        public string OrderId { get; set; }
        [JsonProperty("attempts")]
        public int Attempts { get; set; }
        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }
        [JsonProperty("createdByName")]
        public string CreatedByName { get; set; }
        [JsonProperty("createdByEmail")]
        public string CreatedByEmail { get; set; }
        [JsonProperty("message")]
        public string Message { get; set; }
        [JsonProperty("cloneProcessingFailureDetails")]
        public CloneErrorDetails CloneProcessingFailureDetails { get; set; }
    }
}
