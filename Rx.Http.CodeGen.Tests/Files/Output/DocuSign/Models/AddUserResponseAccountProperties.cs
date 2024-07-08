namespace DocuSign.Models
{
    public class AddUserResponseAccountProperties
    {
        public string Id { get; set; }
        public int SiteId { get; set; }
        public List<ProductPermissionProfileResponse> ProductPermissionProfiles { get; set; }
        public List<DsGroupResponse> DsGroups { get; set; }
        public string CompanyName { get; set; }
        public string JobTitle { get; set; }
    }
}
