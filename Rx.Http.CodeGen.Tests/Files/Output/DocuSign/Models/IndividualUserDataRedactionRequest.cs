namespace DocuSign.Models
{
    public class IndividualUserDataRedactionRequest
    {
        public string UserId { get; set; }
        public List<MembershipDataRedactionRequest> Memberships { get; set; }
    }
}
