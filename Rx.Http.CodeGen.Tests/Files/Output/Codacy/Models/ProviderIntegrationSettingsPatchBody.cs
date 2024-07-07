namespace Codacy.Models
{
    public class ProviderIntegrationSettingsPatchBody
    {
        public bool CommitStatus { get; set; }
        public bool PullRequestComment { get; set; }
        public bool PullRequestSummary { get; set; }
        public bool CoverageSummary { get; set; }
        public bool Suggestions { get; set; }
        public bool AiEnhancedComments { get; set; }
    }
}
