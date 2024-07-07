namespace Codacy.Models
{
    public class PullRequest
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public string Updated { get; set; }
        public string Status { get; set; }
        public string Repository { get; set; }
        public string Title { get; set; }
        public PullRequestOwner Owner { get; set; }
        public string HeadCommitSha { get; set; }
        public string CommonAncestorCommitSha { get; set; }
        public string OriginBranch { get; set; }
        public string TargetBranch { get; set; }
        public string GitHref { get; set; }
    }
}
