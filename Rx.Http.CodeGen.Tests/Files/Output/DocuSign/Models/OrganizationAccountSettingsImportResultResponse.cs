namespace DocuSign.Models
{
    public class OrganizationAccountSettingsImportResultResponse
    {
        public string Id { get; set; }
        public int SiteId { get; set; }
        public string Url { get; set; }
        public int NumberProcessedAccounts { get; set; }
        public OasirrErrorDetails ErrorDetails { get; set; }
        public List<OasirrOrganizationAccountSettingsErrorDataResponse> ProcessingIssuesByAccount { get; set; }
        public int NumberUnprocessedAccounts { get; set; }
    }
}
