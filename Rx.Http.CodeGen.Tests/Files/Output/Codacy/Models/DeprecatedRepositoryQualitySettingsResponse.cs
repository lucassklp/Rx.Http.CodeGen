using Newtonsoft.Json;

namespace Codacy.Models
{
    public class DeprecatedRepositoryQualitySettingsResponse
    {
        [JsonProperty("data")]
        public DeprecatedRepositoryQualitySettings Data { get; set; }
    }
}
