using Newtonsoft.Json;

namespace DocuSign.Models
{
    public class OrgReportListResponse
    {
        [JsonProperty("reports")]
        public List<OrgReportListResponseOrgReport> Reports { get; set; }
    }
}
