namespace DocuSign.Models
{
    public class IndividualUserDataRedactionResponse
    {
        public string UserId { get; set; }
        public string Status { get; set; }
        public List<MembershipDataRedactionResponse> MembershipResults { get; set; }
    }
}
