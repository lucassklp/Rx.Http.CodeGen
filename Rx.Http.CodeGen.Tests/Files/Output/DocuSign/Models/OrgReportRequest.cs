using Newtonsoft.Json;

namespace DocuSign.Models
{
    public class OrgReportRequest
    {
        [JsonProperty("report_type")]
        public string ReportType { get; set; }
        [JsonProperty("report_date_range")]
        public string ReportDateRange { get; set; }
        [JsonProperty("account_ids")]
        public List<string> AccountIds { get; set; }
        [JsonProperty("custom_start_date")]
        public string CustomStartDate { get; set; }
        [JsonProperty("custom_end_date")]
        public string CustomEndDate { get; set; }
    }
}
