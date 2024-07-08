namespace DocuSign.Models
{
    public class OrgReportListResponseOrgReport
    {
        public bool Complete { get; set; }
        public string ReportCorrelationId { get; set; }
        public int SiteId { get; set; }
        public string ReportId { get; set; }
        public OrgReportListResponseRequestor Requestor { get; set; }
        public string CreatedOn { get; set; }
        public int AccountExportCount { get; set; }
        public string Url { get; set; }
        public string ReportTypeId { get; set; }
        public string ReportDateRange { get; set; }
        public string CustomStartDate { get; set; }
        public string CustomEndDate { get; set; }
    }
}
