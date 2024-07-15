using Newtonsoft.Json;

namespace Codacy.Models
{
    public class ClonesResponse
    {
        [JsonProperty("data")]
        public List<CommitFileClone> Data { get; set; }
        [JsonProperty("pagination")]
        public PaginationInfo Pagination { get; set; }
    }
}
