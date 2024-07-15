using Newtonsoft.Json;

namespace Codacy.Models
{
    public class SyncProviderSettingOrganizationResponse
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
