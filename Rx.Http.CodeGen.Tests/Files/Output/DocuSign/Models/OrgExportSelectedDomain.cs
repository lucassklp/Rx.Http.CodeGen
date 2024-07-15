using Newtonsoft.Json;

namespace DocuSign.Models
{
    public class OrgExportSelectedDomain
    {
        [JsonProperty("domain")]
        public string Domain { get; set; }
    }
}
