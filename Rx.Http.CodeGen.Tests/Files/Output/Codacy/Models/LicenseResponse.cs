using Newtonsoft.Json;

namespace Codacy.Models
{
    public class LicenseResponse
    {
        [JsonProperty("data")]
        public string Data { get; set; }
    }
}
