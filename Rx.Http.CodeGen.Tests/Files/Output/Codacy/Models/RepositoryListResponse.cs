namespace Codacy.Models
{
    public class RepositoryListResponse
    {
        public PaginationInfo Pagination { get; set; }
        public List<Repository> Data { get; set; }
    }
}
