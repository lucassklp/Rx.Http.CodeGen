namespace DocuSign.Models
{
    public class SingleAccountUserImport
    {
        public string Id { get; set; }
        public string Type { get; set; }
        public OrganizationImportResponseRequestor Requestor { get; set; }
        public string Created { get; set; }
        public string LastModified { get; set; }
        public string Status { get; set; }
        public int UserCount { get; set; }
        public int ProcessedUserCount { get; set; }
        public int AddedUserCount { get; set; }
        public int UpdatedUserCount { get; set; }
        public int ClosedUserCount { get; set; }
        public int NoActionRequiredUserCount { get; set; }
        public int ErrorCount { get; set; }
        public int WarningCount { get; set; }
        public string InvalidColumnHeaders { get; set; }
        public string ImportsNotFoundOrNotAvailableForAccounts { get; set; }
        public string ImportsFailedForAccounts { get; set; }
        public string ImportsTimedOutForAccounts { get; set; }
        public string ImportsNotFoundOrNotAvailableForSites { get; set; }
        public string ImportsFailedForSites { get; set; }
        public string ImportsTimedOutForSites { get; set; }
        public List<OrganizationImportResponseErrorRollup> FileLevelErrorRollups { get; set; }
        public List<OrganizationImportResponseErrorRollup> UserLevelErrorRollups { get; set; }
        public List<OrganizationImportResponseWarningRollup> UserLevelWarningRollups { get; set; }
        public bool HasCsvResults { get; set; }
        public string ResultsUri { get; set; }
    }
}
