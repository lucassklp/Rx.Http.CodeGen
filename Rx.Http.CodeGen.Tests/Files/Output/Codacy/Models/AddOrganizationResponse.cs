using Newtonsoft.Json;

namespace Codacy.Models
{
    public class AddOrganizationResponse
    {
        [JsonProperty("organization")]
        public Organization Organization { get; set; }
        [JsonProperty("warnings")]
        public List<string> Warnings { get; set; }
    }
}
