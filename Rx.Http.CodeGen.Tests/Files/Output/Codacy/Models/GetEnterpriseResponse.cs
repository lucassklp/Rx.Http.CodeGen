using Newtonsoft.Json;

namespace Codacy.Models
{
    public class GetEnterpriseResponse
    {
        [JsonProperty("data")]
        public EnterpriseEntity Data { get; set; }
    }
}
