namespace Codacy.Models
{
    public class Commit
    {
        public string Sha { get; set; }
        public int Id { get; set; }
        public string CommitTimestamp { get; set; }
        public string AuthorName { get; set; }
        public string AuthorEmail { get; set; }
        public string Message { get; set; }
        public string StartedAnalysis { get; set; }
        public string EndedAnalysis { get; set; }
        public bool IsMergeCommit { get; set; }
        public string GitHref { get; set; }
        public List<string> Parents { get; set; }
    }
}
