namespace DocuSign.Models
{
    public class DeleteResponse
    {
        public bool Success { get; set; }
        public List<UserIdentityResponse> Identities { get; set; }
    }
}
