namespace Codacy.Models
{
    public class PullRequestWithCoverage
    {
        public PullRequest PullRequest { get; set; }
        public PullRequestCoverage Coverage { get; set; }
    }
}
