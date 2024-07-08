namespace DocuSign.Models
{
    public class AddDsGroupUsersResponse
    {
        public bool IsSuccess { get; set; }
        public int TotalCount { get; set; }
        public List<DsGroupUserResponse> Users { get; set; }
    }
}
