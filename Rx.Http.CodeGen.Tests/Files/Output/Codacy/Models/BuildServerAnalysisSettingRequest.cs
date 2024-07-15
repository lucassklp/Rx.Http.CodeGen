using Newtonsoft.Json;

namespace Codacy.Models
{
    public class BuildServerAnalysisSettingRequest
    {
        [JsonProperty("buildServerAnalysisSetting")]
        public bool BuildServerAnalysisSetting { get; set; }
    }
}
