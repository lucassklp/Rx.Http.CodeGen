namespace DocuSign.Models
{
    public class UpdateMembershipRequest
    {
        public string AccountId { get; set; }
        public PermissionProfileRequest PermissionProfile { get; set; }
        public List<GroupRequest> Groups { get; set; }
        public string CompanyName { get; set; }
        public string JobTitle { get; set; }
        public bool SendActivation { get; set; }
        public string AccessCode { get; set; }
    }
}
