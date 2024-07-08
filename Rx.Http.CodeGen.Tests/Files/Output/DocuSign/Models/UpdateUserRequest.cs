namespace DocuSign.Models
{
    public class UpdateUserRequest
    {
        public string Id { get; set; }
        public int SiteId { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string DefaultAccountId { get; set; }
        public string LanguageCulture { get; set; }
        public string SelectedLanguages { get; set; }
        public string FederatedStatus { get; set; }
        public bool ForcePasswordChange { get; set; }
        public List<UpdateMembershipRequest> Memberships { get; set; }
        public bool DeviceVerificationEnabled { get; set; }
    }
}
