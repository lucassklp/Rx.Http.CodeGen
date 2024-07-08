namespace DocuSign.Models
{
    public class AssetGroupAccountClone
    {
        public AssetGroupAccountCloneSourceAccount SourceAccount { get; set; }
        public AssetGroupAccountCloneTargetAccount TargetAccount { get; set; }
        public string AssetGroupWorkId { get; set; }
        public string AssetGroupId { get; set; }
        public string AssetGroupWorkType { get; set; }
        public string Status { get; set; }
        public string CloneRequestId { get; set; }
        public string OrderId { get; set; }
        public int Attempts { get; set; }
        public string CreatedDate { get; set; }
        public string CreatedByName { get; set; }
        public string CreatedByEmail { get; set; }
        public string Message { get; set; }
        public CloneErrorDetails CloneProcessingFailureDetails { get; set; }
    }
}
