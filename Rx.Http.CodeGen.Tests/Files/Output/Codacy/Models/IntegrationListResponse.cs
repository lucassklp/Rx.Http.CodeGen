namespace Codacy.Models
{
    public class IntegrationListResponse
    {
        public PaginationInfo Pagination { get; set; }
        public List<Integration> Data { get; set; }
    }
}
