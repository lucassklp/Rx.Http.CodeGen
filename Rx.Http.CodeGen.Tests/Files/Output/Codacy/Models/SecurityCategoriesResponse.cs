namespace Codacy.Models
{
    public class SecurityCategoriesResponse
    {
        public PaginationInfo Pagination { get; set; }
        public List<string> Data { get; set; }
    }
}
