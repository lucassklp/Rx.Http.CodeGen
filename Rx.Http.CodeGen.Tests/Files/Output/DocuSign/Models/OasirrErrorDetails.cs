using Newtonsoft.Json;

namespace DocuSign.Models
{
    public class OasirrErrorDetails
    {
        [JsonProperty("error")]
        public string Error { get; set; }
        [JsonProperty("error_description")]
        public string ErrorDescription { get; set; }
    }
}
