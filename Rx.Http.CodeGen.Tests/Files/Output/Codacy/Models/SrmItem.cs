namespace Codacy.Models
{
    public class SrmItem
    {
        public string Id { get; set; }
        public string ItemSource { get; set; }
        public string ItemSourceId { get; set; }
        public string Title { get; set; }
        public string Repository { get; set; }
        public string OpenedAt { get; set; }
        public string ClosedAt { get; set; }
        public string DueAt { get; set; }
        public string Priority { get; set; }
        public string Status { get; set; }
        public string HtmlUrl { get; set; }
        public string ProjectKey { get; set; }
        public string SecurityCategory { get; set; }
        public string ScanType { get; set; }
        public string Summary { get; set; }
        public float CvssScore { get; set; }
        public string CvssVector { get; set; }
        public string Cwe { get; set; }
        public string AffectedTargets { get; set; }
        public string AdditionalInfo { get; set; }
        public string Likelihood { get; set; }
        public string EffortToFix { get; set; }
        public string Remediation { get; set; }
    }
}
