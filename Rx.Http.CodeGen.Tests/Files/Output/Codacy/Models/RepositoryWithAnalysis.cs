namespace Codacy.Models
{
    public class RepositoryWithAnalysis
    {
        public Commit LastAnalysedCommit { get; set; }
        public int Grade { get; set; }
        public string GradeLetter { get; set; }
        public int IssuesPercentage { get; set; }
        public int IssuesCount { get; set; }
        public int ComplexFilesPercentage { get; set; }
        public int ComplexFilesCount { get; set; }
        public int DuplicationPercentage { get; set; }
        public Repository Repository { get; set; }
        public Branch Branch { get; set; }
        public Branch SelectedBranch { get; set; }
        public Coverage Coverage { get; set; }
    }
}
