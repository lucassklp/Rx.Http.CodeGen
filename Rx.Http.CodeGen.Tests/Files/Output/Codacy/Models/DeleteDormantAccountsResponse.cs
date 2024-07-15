using Newtonsoft.Json;

namespace Codacy.Models
{
    public class DeleteDormantAccountsResponse
    {
        [JsonProperty("data")]
        public List<DormantAccountInfo> Data { get; set; }
    }
}
