using Newtonsoft.Json;

namespace Codacy.Models
{
    public class RemovePeopleEmailStatus
    {
        [JsonProperty("email")]
        public string Email { get; set; }
        [JsonProperty("error")]
        public string Error { get; set; }
    }
}
