using Newtonsoft.Json;

namespace Codacy.Models
{
    public class EnterpriseListResponse
    {
        [JsonProperty("data")]
        public List<EnterpriseEntity> Data { get; set; }
        [JsonProperty("pagination")]
        public PaginationInfo Pagination { get; set; }
    }
}
