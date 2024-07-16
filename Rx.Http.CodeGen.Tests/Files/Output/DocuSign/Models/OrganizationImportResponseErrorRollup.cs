using Newtonsoft.Json;

namespace DocuSign.Models
{
    public class OrganizationImportResponseErrorRollup
    {
        [JsonProperty("error_type")]
        public string ErrorType { get; set; }
        [JsonProperty("count")]
        public int Count { get; set; }
    }
}
