using Newtonsoft.Json;

namespace DocuSign.Models
{
    public class OrgReportListResponseOrgReport
    {
        [JsonProperty("complete")]
        public bool Complete { get; set; }
        [JsonProperty("report_correlation_id")]
        public string ReportCorrelationId { get; set; }
        [JsonProperty("site_id")]
        public int SiteId { get; set; }
        [JsonProperty("report_id")]
        public string ReportId { get; set; }
        [JsonProperty("requestor")]
        public OrgReportListResponseRequestor Requestor { get; set; }
        [JsonProperty("created_on")]
        public string CreatedOn { get; set; }
        [JsonProperty("account_export_count")]
        public int AccountExportCount { get; set; }
        [JsonProperty("url")]
        public string Url { get; set; }
        [JsonProperty("report_type_id")]
        public string ReportTypeId { get; set; }
        [JsonProperty("report_date_range")]
        public string ReportDateRange { get; set; }
        [JsonProperty("custom_start_date")]
        public string CustomStartDate { get; set; }
        [JsonProperty("custom_end_date")]
        public string CustomEndDate { get; set; }
    }
}
