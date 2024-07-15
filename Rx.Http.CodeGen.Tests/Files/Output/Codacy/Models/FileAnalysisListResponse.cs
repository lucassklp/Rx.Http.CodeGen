using Newtonsoft.Json;

namespace Codacy.Models
{
    public class FileAnalysisListResponse
    {
        [JsonProperty("pagination")]
        public PaginationInfo Pagination { get; set; }
        [JsonProperty("data")]
        public List<FileDeltaAnalysis> Data { get; set; }
    }
}
