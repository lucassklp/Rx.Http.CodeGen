namespace DocuSign.Models
{
    public class DsGroupUserResponse
    {
        public string UserId { get; set; }
        public string AccountId { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string Status { get; set; }
        public ErrorDetails ErrorDetails { get; set; }
    }
}
