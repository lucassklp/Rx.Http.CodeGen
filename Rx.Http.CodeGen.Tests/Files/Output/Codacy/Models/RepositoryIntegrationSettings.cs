using Newtonsoft.Json;

namespace Codacy.Models
{
    public class RepositoryIntegrationSettings
    {
        [JsonProperty("settings")]
        public ProviderIntegrationSettingsBody Settings { get; set; }
        [JsonProperty("integratedBy")]
        public string IntegratedBy { get; set; }
    }
}
