namespace DocuSign.Models
{
    public class RemoveDsGroupUsersResponse
    {
        public bool IsSuccess { get; set; }
        public List<DsGroupUserResponse> FailedUsers { get; set; }
    }
}
