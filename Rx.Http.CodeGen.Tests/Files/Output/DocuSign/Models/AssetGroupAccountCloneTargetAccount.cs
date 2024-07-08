namespace DocuSign.Models
{
    public class AssetGroupAccountCloneTargetAccount
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Region { get; set; }
        public string CountryCode { get; set; }
        public string Site { get; set; }
        public AssetGroupAccountCloneTargetAccountAdmin Admin { get; set; }
    }
}
