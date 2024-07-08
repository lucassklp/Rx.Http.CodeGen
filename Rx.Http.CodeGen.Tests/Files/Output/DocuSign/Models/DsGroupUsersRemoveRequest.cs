namespace DocuSign.Models
{
    public class DsGroupUsersRemoveRequest
    {
        public List<string> UserIds { get; set; }
        public List<string> UserEmails { get; set; }
    }
}
