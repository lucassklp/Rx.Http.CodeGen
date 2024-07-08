namespace Codacy.Models
{
    public class RepositoryIntegrationSettings
    {
        public ProviderIntegrationSettingsBody Settings { get; set; }
        public string IntegratedBy { get; set; }
    }
}
