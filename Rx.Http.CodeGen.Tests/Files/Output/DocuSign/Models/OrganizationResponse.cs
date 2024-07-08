namespace DocuSign.Models
{
    public class OrganizationResponse
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string DefaultAccountId { get; set; }
        public int DefaultPermissionProfileId { get; set; }
        public string CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public string LastModifiedOn { get; set; }
        public string LastModifiedBy { get; set; }
        public List<OrganizationAccountResponse> Accounts { get; set; }
        public List<OrganizationSimpleIdObject> Users { get; set; }
        public List<DomainResponse> ReservedDomains { get; set; }
        public List<IdentityProvidersResponse> IdentityProviders { get; set; }
        public List<LinkResponse> Links { get; set; }
    }
}
