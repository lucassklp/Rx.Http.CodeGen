namespace Codacy.Models
{
    public class SecurityRepositoriesResponse
    {
        public PaginationInfo Pagination { get; set; }
        public List<RepositorySummary> Data { get; set; }
    }
}
