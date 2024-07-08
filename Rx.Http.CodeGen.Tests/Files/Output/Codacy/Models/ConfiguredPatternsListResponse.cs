namespace Codacy.Models
{
    public class ConfiguredPatternsListResponse
    {
        public List<ConfiguredPattern> Data { get; set; }
        public PaginationInfo Pagination { get; set; }
        public ConfiguredPatternListMeta Meta { get; set; }
    }
}
