namespace DocuSign.Models
{
    public class MembershipResponse
    {
        public string Email { get; set; }
        public string AccountId { get; set; }
        public string ExternalAccountId { get; set; }
        public string AccountName { get; set; }
        public bool IsExternalAccount { get; set; }
        public string Status { get; set; }
        public PermissionProfileResponse PermissionProfile { get; set; }
        public string CreatedOn { get; set; }
        public List<MemberGroupResponse> Groups { get; set; }
        public bool IsAdmin { get; set; }
    }
}
