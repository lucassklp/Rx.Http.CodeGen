namespace DocuSign.Models
{
    public class OrganizationExportRequest
    {
        public string Type { get; set; }
        public List<OrganizationExportAccount> Accounts { get; set; }
        public List<OrganizationExportDomain> Domains { get; set; }
    }
}
