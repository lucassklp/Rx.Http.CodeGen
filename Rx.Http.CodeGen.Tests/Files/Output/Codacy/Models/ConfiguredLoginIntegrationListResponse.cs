namespace Codacy.Models
{
    public class ConfiguredLoginIntegrationListResponse
    {
        public PaginationInfo Pagination { get; set; }
        public List<ConfiguredLoginIntegration> Data { get; set; }
    }
}
