using Newtonsoft.Json;

namespace DocuSign.Models
{
    public class ErrorDetails
    {
        [JsonProperty("error")]
        public string Error { get; set; }
        [JsonProperty("error_description")]
        public string ErrorDescription { get; set; }
    }
}
