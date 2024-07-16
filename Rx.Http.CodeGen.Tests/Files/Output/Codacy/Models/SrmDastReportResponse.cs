using Newtonsoft.Json;

namespace Codacy.Models
{
    public class SrmDastReportResponse
    {
        [JsonProperty("data")]
        public List<SrmDastReport> Data { get; set; }
        [JsonProperty("pagination")]
        public PaginationInfo Pagination { get; set; }
    }
}
