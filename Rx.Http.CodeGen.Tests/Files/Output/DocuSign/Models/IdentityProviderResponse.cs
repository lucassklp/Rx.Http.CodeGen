namespace DocuSign.Models
{
    public class IdentityProviderResponse
    {
        public string Id { get; set; }
        public string FriendlyName { get; set; }
        public bool AutoProvisionUsers { get; set; }
        public string Type { get; set; }
        public Saml2IdentityProviderResponse Saml20 { get; set; }
        public List<LinkResponse> Links { get; set; }
    }
}
