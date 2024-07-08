namespace DocuSign.Models
{
    public class DsGroupResponse
    {
        public string DsGroupId { get; set; }
        public string AccountId { get; set; }
        public string SourceProductName { get; set; }
        public string GroupId { get; set; }
        public string GroupName { get; set; }
        public string Description { get; set; }
        public bool IsAdmin { get; set; }
        public string LastModifiedOn { get; set; }
        public int UserCount { get; set; }
        public int ExternalAccountId { get; set; }
        public string AccountName { get; set; }
    }
}
