namespace DocuSign.Models
{
    public class OrganizationSalesforceAccountManagersResponse
    {
        public string AccountId { get; set; }
        public string AccountName { get; set; }
        public string AccountType { get; set; }
        public OsamrContact AccountOwner { get; set; }
        public OsamrContact AccountManager { get; set; }
        public OrganizationSalesforceAccountManagersResponse ParentAccount { get; set; }
    }
}
