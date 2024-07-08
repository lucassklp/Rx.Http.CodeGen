namespace DocuSign.Models
{
    public class MemberGroupsResponse
    {
        public List<MemberGroupResponse> Groups { get; set; }
        public PagingResponseProperties Paging { get; set; }
    }
}
