namespace Codacy.Models
{
    public class ProviderIntegrationListResponse
    {
        public PaginationInfo Pagination { get; set; }
        public List<ProviderIntegration> Data { get; set; }
    }
}
