using Newtonsoft.Json;

namespace Codacy.Models
{
    public class PaginationInfo
    {
        [JsonProperty("cursor")]
        public string Cursor { get; set; }
        [JsonProperty("limit")]
        public int Limit { get; set; }
        [JsonProperty("total")]
        public int Total { get; set; }
    }
}
