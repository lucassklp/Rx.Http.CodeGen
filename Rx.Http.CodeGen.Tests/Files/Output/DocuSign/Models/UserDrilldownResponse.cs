namespace DocuSign.Models
{
    public class UserDrilldownResponse
    {
        public string Id { get; set; }
        public int SiteId { get; set; }
        public string SiteName { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserStatus { get; set; }
        public string DefaultAccountId { get; set; }
        public string DefaultAccountName { get; set; }
        public string LanguageCulture { get; set; }
        public string SelectedLanguages { get; set; }
        public string FederatedStatus { get; set; }
        public bool IsOrganizationAdmin { get; set; }
        public string CreatedOn { get; set; }
        public string LastLogin { get; set; }
        public List<MembershipResponse> Memberships { get; set; }
        public List<UserIdentityResponse> Identities { get; set; }
        public bool DeviceVerificationEnabled { get; set; }
    }
}
