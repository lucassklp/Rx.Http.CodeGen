namespace DocuSign.Models
{
    public class OrgReportRequest
    {
        public string ReportType { get; set; }
        public string ReportDateRange { get; set; }
        public List<string> AccountIds { get; set; }
        public string CustomStartDate { get; set; }
        public string CustomEndDate { get; set; }
    }
}
