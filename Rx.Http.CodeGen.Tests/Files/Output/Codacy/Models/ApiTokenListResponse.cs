namespace Codacy.Models
{
    public class ApiTokenListResponse
    {
        public PaginationInfo Pagination { get; set; }
        public List<ApiToken> Data { get; set; }
    }
}
