namespace Codacy.Models
{
    public class CoveragePullRequestCommitDetail
    {
        public int CommitId { get; set; }
        public string CommitSha { get; set; }
        public List<PullRequestCoverageReport> Reports { get; set; }
    }
}
