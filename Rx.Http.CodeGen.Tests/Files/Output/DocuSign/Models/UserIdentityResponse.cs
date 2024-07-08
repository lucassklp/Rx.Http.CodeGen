namespace DocuSign.Models
{
    public class UserIdentityResponse
    {
        public string Id { get; set; }
        public string ProviderId { get; set; }
        public string UserId { get; set; }
        public string ImmutableId { get; set; }
        public ErrorDetails ErrorDetails { get; set; }
    }
}
