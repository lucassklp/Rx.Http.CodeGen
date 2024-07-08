namespace DocuSign.Models
{
    public class UpdateUserEmailRequest
    {
        public string Id { get; set; }
        public int SiteId { get; set; }
        public string Email { get; set; }
    }
}
