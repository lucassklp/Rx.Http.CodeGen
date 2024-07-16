using Newtonsoft.Json;

namespace Codacy.Models
{
    public class FirstAnalysisOverview
    {
        [JsonProperty("action")]
        public string Action { get; set; }
        [JsonProperty("complete")]
        public bool Complete { get; set; }
    }
}
