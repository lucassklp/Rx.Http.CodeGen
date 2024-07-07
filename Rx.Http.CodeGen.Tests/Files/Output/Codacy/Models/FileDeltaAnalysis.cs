namespace Codacy.Models
{
    public class FileDeltaAnalysis
    {
        public FileMetadata File { get; set; }
        public FileDeltaCoverageAnalysis Coverage { get; set; }
        public FileDeltaQualityAnalysis Quality { get; set; }
        public object ComparedWithCommit { get; set; }
    }
}
