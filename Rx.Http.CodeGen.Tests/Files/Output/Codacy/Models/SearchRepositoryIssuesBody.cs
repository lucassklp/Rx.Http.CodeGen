namespace Codacy.Models
{
    public class SearchRepositoryIssuesBody
    {
        public string BranchName { get; set; }
        public List<string> PatternIds { get; set; }
        public List<string> Languages { get; set; }
        public List<string> Categories { get; set; }
        public List<string> Levels { get; set; }
        public List<string> AuthorEmails { get; set; }
    }
}
