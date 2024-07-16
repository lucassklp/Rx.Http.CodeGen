using Newtonsoft.Json;

namespace Codacy.Models
{
    public class ProviderIntegrationSettingsBody
    {
        [JsonProperty("commitStatus")]
        public bool CommitStatus { get; set; }
        [JsonProperty("pullRequestComment")]
        public bool PullRequestComment { get; set; }
        [JsonProperty("pullRequestSummary")]
        public bool PullRequestSummary { get; set; }
        [JsonProperty("coverageSummary")]
        public bool CoverageSummary { get; set; }
        [JsonProperty("suggestions")]
        public bool Suggestions { get; set; }
        [JsonProperty("aiEnhancedComments")]
        public bool AiEnhancedComments { get; set; }
    }
}
