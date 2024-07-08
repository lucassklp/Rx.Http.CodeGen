namespace Codacy.Models
{
    public class FileInformationWithAnalysis
    {
        public FileMetadata File { get; set; }
        public FileMetrics Metrics { get; set; }
        public FileCoverageAnalysis Coverage { get; set; }
        public FileQualityInfo Quality { get; set; }
    }
}
