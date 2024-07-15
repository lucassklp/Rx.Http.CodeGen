using Newtonsoft.Json;

namespace Codacy.Models
{
    public class ToolListResponse
    {
        [JsonProperty("data")]
        public List<Tool> Data { get; set; }
        [JsonProperty("pagination")]
        public PaginationInfo Pagination { get; set; }
    }
}
