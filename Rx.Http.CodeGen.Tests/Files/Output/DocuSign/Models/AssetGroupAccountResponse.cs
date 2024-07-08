namespace DocuSign.Models
{
    public class AssetGroupAccountResponse
    {
        public string AssetGroupId { get; set; }
        public string AssetGroupName { get; set; }
        public string AccountId { get; set; }
        public string AccountName { get; set; }
        public int ExternalAccountId { get; set; }
        public bool Compliant { get; set; }
        public int SiteId { get; set; }
        public string SiteName { get; set; }
    }
}
