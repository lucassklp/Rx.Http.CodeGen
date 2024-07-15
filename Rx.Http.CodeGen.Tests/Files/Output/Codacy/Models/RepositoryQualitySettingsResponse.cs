using Newtonsoft.Json;

namespace Codacy.Models
{
    public class RepositoryQualitySettingsResponse
    {
        [JsonProperty("data")]
        public RepositoryQualitySettings Data { get; set; }
    }
}
