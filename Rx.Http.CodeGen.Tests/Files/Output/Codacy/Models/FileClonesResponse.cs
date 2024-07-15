using Newtonsoft.Json;

namespace Codacy.Models
{
    public class FileClonesResponse
    {
        [JsonProperty("data")]
        public List<FileClone> Data { get; set; }
        [JsonProperty("pagination")]
        public PaginationInfo Pagination { get; set; }
    }
}
