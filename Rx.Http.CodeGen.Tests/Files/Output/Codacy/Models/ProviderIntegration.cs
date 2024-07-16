using Newtonsoft.Json;

namespace Codacy.Models
{
    public class ProviderIntegration
    {
        [JsonProperty("provider")]
        public string Provider { get; set; }
        [JsonProperty("redirectUrl")]
        public string RedirectUrl { get; set; }
    }
}
