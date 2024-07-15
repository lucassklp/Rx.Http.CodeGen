using Newtonsoft.Json;

namespace Codacy.Models
{
    public class SecurityComponentsResponse
    {
        [JsonProperty("items")]
        public List<object> Items { get; set; }
    }
}
