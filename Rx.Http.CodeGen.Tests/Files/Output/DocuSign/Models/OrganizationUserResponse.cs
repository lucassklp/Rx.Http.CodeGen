namespace DocuSign.Models
{
    public class OrganizationUserResponse
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserStatus { get; set; }
        public string MembershipStatus { get; set; }
        public string Email { get; set; }
        public string CreatedOn { get; set; }
        public string MembershipCreatedOn { get; set; }
        public List<DsGroupResponse> DsGroups { get; set; }
        public string MembershipId { get; set; }
    }
}
