namespace DocuSign.Models
{
    public class UsersUpdateResponse
    {
        public bool Success { get; set; }
        public List<UserUpdateResponse> Users { get; set; }
    }
}
