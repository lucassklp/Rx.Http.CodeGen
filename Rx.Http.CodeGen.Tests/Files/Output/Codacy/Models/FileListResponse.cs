using Newtonsoft.Json;

namespace Codacy.Models
{
    public class FileListResponse
    {
        [JsonProperty("data")]
        public List<FileWithAnalysisInfo> Data { get; set; }
        [JsonProperty("pagination")]
        public PaginationInfo Pagination { get; set; }
    }
}
