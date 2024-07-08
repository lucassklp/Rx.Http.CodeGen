namespace Codacy.Models
{
    public class RepositorySuggestedAuthorsResponse
    {
        public PaginationInfo Pagination { get; set; }
        public List<RepositorySuggestedAuthor> Data { get; set; }
    }
}
