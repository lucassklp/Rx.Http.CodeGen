namespace DocuSign.Models
{
    public class UserUpdateResponse
    {
        public string Id { get; set; }
        public int SiteId { get; set; }
        public string Email { get; set; }
        public ErrorDetails ErrorDetails { get; set; }
    }
}
