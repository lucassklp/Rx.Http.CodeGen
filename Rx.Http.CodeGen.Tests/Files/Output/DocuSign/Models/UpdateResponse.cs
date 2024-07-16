using Newtonsoft.Json;

namespace DocuSign.Models
{
    public class UpdateResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
