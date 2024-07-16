using Newtonsoft.Json;

namespace DocuSign.Models
{
    public class OrgReportListResponseRequestor
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
