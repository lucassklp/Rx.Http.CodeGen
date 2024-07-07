namespace Codacy.Models
{
    public class CoverageReport
    {
        public string TargetCommitSha { get; set; }
        public CommitWithBranches Commit { get; set; }
        public string Language { get; set; }
        public string CreatedAt { get; set; }
        public string Status { get; set; }
    }
}
