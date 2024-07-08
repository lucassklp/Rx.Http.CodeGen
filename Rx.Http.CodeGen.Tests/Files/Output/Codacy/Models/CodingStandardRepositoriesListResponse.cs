namespace Codacy.Models
{
    public class CodingStandardRepositoriesListResponse
    {
        public List<RepositoryIdentification> Data { get; set; }
        public PaginationInfo Pagination { get; set; }
    }
}
