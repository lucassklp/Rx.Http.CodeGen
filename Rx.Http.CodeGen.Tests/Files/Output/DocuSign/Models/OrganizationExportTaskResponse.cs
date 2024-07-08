namespace DocuSign.Models
{
    public class OrganizationExportTaskResponse
    {
        public string Id { get; set; }
        public int SiteId { get; set; }
        public string Url { get; set; }
        public int NumberRows { get; set; }
        public int SizeBytes { get; set; }
        public OetrErrorDetails ErrorDetails { get; set; }
    }
}
