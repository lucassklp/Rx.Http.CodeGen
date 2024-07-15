using Newtonsoft.Json;

namespace Codacy.Models
{
    public class OrganizationResponse
    {
        [JsonProperty("data")]
        public Organization Data { get; set; }
    }
}
