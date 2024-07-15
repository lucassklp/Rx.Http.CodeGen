using Newtonsoft.Json;

namespace Codacy.Models
{
    public class SyncProviderSettingResponse
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("visibility")]
        public string Visibility { get; set; }
    }
}
