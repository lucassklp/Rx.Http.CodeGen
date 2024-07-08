namespace Codacy.Models
{
    public class SuggestedAuthor
    {
        public string CommitEmail { get; set; }
        public int TotalProjects { get; set; }
        public int TotalCommits { get; set; }
        public string LastCommit { get; set; }
        public List<ProjectCommitStat> ProjectCommitStats { get; set; }
    }
}
