namespace DocuSign.Models
{
    public class NewUserRequestAccountProperties
    {
        public string Id { get; set; }
        public PermissionProfileRequest PermissionProfile { get; set; }
        public List<GroupRequest> Groups { get; set; }
        public string CompanyName { get; set; }
        public string JobTitle { get; set; }
    }
}
