namespace DocuSign.Models
{
    public class DomainResponse
    {
        public string Id { get; set; }
        public string Status { get; set; }
        public string HostName { get; set; }
        public string TxtToken { get; set; }
        public string IdentityProviderId { get; set; }
        public List<SettingResponse> Settings { get; set; }
        public List<LinkResponse> Links { get; set; }
    }
}
