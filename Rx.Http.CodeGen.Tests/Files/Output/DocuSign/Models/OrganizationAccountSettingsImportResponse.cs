namespace DocuSign.Models
{
    public class OrganizationAccountSettingsImportResponse
    {
        public string Created { get; set; }
        public string LastModified { get; set; }
        public string Completed { get; set; }
        public string Expires { get; set; }
        public int PercentCompleted { get; set; }
        public int NumberProcessedAccounts { get; set; }
        public int NumberUnprocessedAccounts { get; set; }
        public List<OrganizationAccountSettingsImportResultResponse> Results { get; set; }
        public bool Success { get; set; }
        public object SkippedSettingsByAccount { get; set; }
        public string Id { get; set; }
        public string OrganizationId { get; set; }
        public string Status { get; set; }
        public string Type { get; set; }
        public OrganizationAccountSettingsImportRequestorResponse Requestor { get; set; }
    }
}
