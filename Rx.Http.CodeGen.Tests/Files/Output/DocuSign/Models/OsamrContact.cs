using Newtonsoft.Json;

namespace DocuSign.Models
{
    public class OsamrContact
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("email")]
        public string Email { get; set; }
        [JsonProperty("title")]
        public string Title { get; set; }
    }
}
