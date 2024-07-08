namespace DocuSign.Models
{
    public class DeleteMembershipsResponse
    {
        public bool Success { get; set; }
        public List<DeleteMembershipResponse> Accounts { get; set; }
    }
}
