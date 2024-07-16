using Newtonsoft.Json;

namespace Codacy.Models
{
    public class DormantAccountInfo
    {
        [JsonProperty("email")]
        public string Email { get; set; }
    }
}
