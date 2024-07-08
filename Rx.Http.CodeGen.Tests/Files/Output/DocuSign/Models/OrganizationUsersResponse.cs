namespace DocuSign.Models
{
    public class OrganizationUsersResponse
    {
        public List<OrganizationUserResponse> Users { get; set; }
        public PagingResponseProperties Paging { get; set; }
    }
}
