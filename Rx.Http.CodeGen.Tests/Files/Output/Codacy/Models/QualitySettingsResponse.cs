using Newtonsoft.Json;

namespace Codacy.Models
{
    public class QualitySettingsResponse
    {
        [JsonProperty("data")]
        public QualitySettingsWithGatePolicy Data { get; set; }
    }
}
