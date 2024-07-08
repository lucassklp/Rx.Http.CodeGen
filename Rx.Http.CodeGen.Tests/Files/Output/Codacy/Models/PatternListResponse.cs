namespace Codacy.Models
{
    public class PatternListResponse
    {
        public List<Pattern> Data { get; set; }
        public PaginationInfo Pagination { get; set; }
    }
}
