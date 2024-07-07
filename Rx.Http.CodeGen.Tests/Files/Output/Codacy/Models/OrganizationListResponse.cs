namespace Codacy.Models
{
    public class OrganizationListResponse
    {
        public PaginationInfo Pagination { get; set; }
        public List<Organization> Data { get; set; }
    }
}
