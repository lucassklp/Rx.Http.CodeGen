namespace Codacy.Models
{
    public class FileQualityInfo
    {
        public int TotalIssues { get; set; }
        public int Complexity { get; set; }
        public int Grade { get; set; }
        public string GradeLetter { get; set; }
        public int Duplication { get; set; }
        public int DuplicatedLinesOfCode { get; set; }
    }
}
