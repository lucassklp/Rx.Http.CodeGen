namespace DocuSign.Models
{
    public class NewUserResponseAccountProperties
    {
        public string Id { get; set; }
        public int SiteId { get; set; }
        public PermissionProfileResponse PermissionProfile { get; set; }
        public List<MemberGroupResponse> Groups { get; set; }
        public string CompanyName { get; set; }
        public string JobTitle { get; set; }
    }
}
