using Newtonsoft.Json;

namespace DocuSign.Models
{
    public class OrganizationImportResponseWarningRollup
    {
        [JsonProperty("warning_type")]
        public string WarningType { get; set; }
        [JsonProperty("count")]
        public int Count { get; set; }
    }
}
