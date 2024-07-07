namespace Codacy.Models
{
    public class FileWithAnalysisInfo
    {
        public int FileId { get; set; }
        public int BranchId { get; set; }
        public string Path { get; set; }
        public int TotalIssues { get; set; }
        public int Complexity { get; set; }
        public int Grade { get; set; }
        public string GradeLetter { get; set; }
        public int Coverage { get; set; }
        public double CoverageWithDecimals { get; set; }
        public int Duplication { get; set; }
        public int LinesOfCode { get; set; }
        public int SourceLinesOfCode { get; set; }
        public int NumberOfMethods { get; set; }
        public int NumberOfClones { get; set; }
    }
}
