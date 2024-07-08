namespace DocuSign.Models
{
    public class NewUserRequest
    {
        public List<NewUserRequestAccountProperties> Accounts { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string DefaultAccountId { get; set; }
        public string LanguageCulture { get; set; }
        public string SelectedLanguages { get; set; }
        public string AccessCode { get; set; }
        public string FederatedStatus { get; set; }
        public bool AutoActivateMemberships { get; set; }
    }
}
