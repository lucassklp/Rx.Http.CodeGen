using Newtonsoft.Json;

namespace DocuSign.Models
{
    public class CloneErrorDetails
    {
        [JsonProperty("error")]
        public string Error { get; set; }
        [JsonProperty("errorDescription")]
        public string ErrorDescription { get; set; }
        [JsonProperty("isSystemError")]
        public bool IsSystemError { get; set; }
    }
}
