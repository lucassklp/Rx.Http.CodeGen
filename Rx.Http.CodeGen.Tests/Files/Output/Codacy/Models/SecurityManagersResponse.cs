namespace Codacy.Models
{
    public class SecurityManagersResponse
    {
        public PaginationInfo Pagination { get; set; }
        public List<SecurityManager> Data { get; set; }
    }
}
