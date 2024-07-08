namespace DocuSign.Models
{
    public class Saml2IdentityProviderResponse
    {
        public string Issuer { get; set; }
        public List<SettingResponse> Settings { get; set; }
        public List<CertificateResponse> Certificates { get; set; }
        public List<RequiredAttributeMappingResponse> AttributeMappings { get; set; }
    }
}
