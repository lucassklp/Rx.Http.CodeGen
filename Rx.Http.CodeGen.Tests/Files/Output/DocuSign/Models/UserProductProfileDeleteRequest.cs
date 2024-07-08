namespace DocuSign.Models
{
    public class UserProductProfileDeleteRequest
    {
        public string UserEmail { get; set; }
        public string UserId { get; set; }
        public List<string> ProductIds { get; set; }
    }
}
