namespace Codacy.Models
{
    public class SuggestedAuthorsResponse
    {
        public PaginationInfo Pagination { get; set; }
        public List<SuggestedAuthor> Data { get; set; }
    }
}
