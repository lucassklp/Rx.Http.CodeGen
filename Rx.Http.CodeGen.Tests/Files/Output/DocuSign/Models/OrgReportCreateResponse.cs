using Newtonsoft.Json;

namespace DocuSign.Models
{
    public class OrgReportCreateResponse
    {
        [JsonProperty("report_correlation_id")]
        public string ReportCorrelationId { get; set; }
    }
}
