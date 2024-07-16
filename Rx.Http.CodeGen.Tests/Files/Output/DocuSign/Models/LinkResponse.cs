using Newtonsoft.Json;

namespace DocuSign.Models
{
    public class LinkResponse
    {
        [JsonProperty("rel")]
        public string Rel { get; set; }
        [JsonProperty("href")]
        public string Href { get; set; }
    }
}
