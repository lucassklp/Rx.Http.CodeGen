using Newtonsoft.Json;

namespace Codacy.Models
{
    public class BuildServerAnalysisSettingResponse
    {
        [JsonProperty("buildServerAnalysisSetting")]
        public bool BuildServerAnalysisSetting { get; set; }
    }
}
