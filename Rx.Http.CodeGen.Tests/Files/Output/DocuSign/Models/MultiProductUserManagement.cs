namespace DocuSign.Models
{
    public class MultiProductUserManagement
    {
        public string Id { get; set; }
        public int SiteId { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string LanguageCulture { get; set; }
        public string FederatedStatus { get; set; }
        public List<AddUserResponseAccountProperties> Accounts { get; set; }
    }
}
