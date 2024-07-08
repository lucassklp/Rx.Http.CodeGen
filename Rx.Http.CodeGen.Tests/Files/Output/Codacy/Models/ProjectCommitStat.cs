namespace Codacy.Models
{
    public class ProjectCommitStat
    {
        public int ProjectId { get; set; }
        public string FirstCommit { get; set; }
        public string LastCommit { get; set; }
        public int NumberOfCommits { get; set; }
    }
}
