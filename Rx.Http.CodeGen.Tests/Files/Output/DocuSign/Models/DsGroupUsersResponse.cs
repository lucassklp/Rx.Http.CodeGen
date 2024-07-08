namespace DocuSign.Models
{
    public class DsGroupUsersResponse
    {
        public int Page { get; set; }
        public int PageSize { get; set; }
        public int TotalCount { get; set; }
        public List<DsGroupUserResponse> Users { get; set; }
    }
}
