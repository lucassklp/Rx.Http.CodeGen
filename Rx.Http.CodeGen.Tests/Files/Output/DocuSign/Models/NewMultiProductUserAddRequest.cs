namespace DocuSign.Models
{
    public class NewMultiProductUserAddRequest
    {
        public List<ProductPermissionProfileRequest> ProductPermissionProfiles { get; set; }
        public List<DsGroupRequest> DsGroups { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string DefaultAccountId { get; set; }
        public string LanguageCulture { get; set; }
        public string AccessCode { get; set; }
        public string FederatedStatus { get; set; }
        public bool AutoActivateMemberships { get; set; }
    }
}
