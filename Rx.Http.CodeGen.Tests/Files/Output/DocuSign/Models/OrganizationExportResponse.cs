namespace DocuSign.Models
{
    public class OrganizationExportResponse
    {
        public string Id { get; set; }
        public string Type { get; set; }
        public OrganizationExportRequestorResponse Requestor { get; set; }
        public string Created { get; set; }
        public string LastModified { get; set; }
        public string Completed { get; set; }
        public string Expires { get; set; }
        public string Status { get; set; }
        public List<OrgExportSelectedAccount> SelectedAccounts { get; set; }
        public List<OrgExportSelectedDomain> SelectedDomains { get; set; }
        public string MetadataUrl { get; set; }
        public int PercentCompleted { get; set; }
        public int NumberRows { get; set; }
        public int SizeBytes { get; set; }
        public List<OrganizationExportTaskResponse> Results { get; set; }
        public bool Success { get; set; }
    }
}
