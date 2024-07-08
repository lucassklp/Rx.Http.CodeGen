namespace DocuSign.Models
{
    public class CertificateResponse
    {
        public string Id { get; set; }
        public string Issuer { get; set; }
        public string Thumbprint { get; set; }
        public string ExpirationDate { get; set; }
        public bool IsValid { get; set; }
        public List<LinkResponse> Links { get; set; }
    }
}
