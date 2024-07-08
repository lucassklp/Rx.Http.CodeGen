namespace Codacy.Models
{
    public class AnalysisStepExecutionMetrics
    {
        public string Title { get; set; }
        public string Start { get; set; }
        public string End { get; set; }
        public int ActiveExecutionTime { get; set; }
        public int TotalExecutionTime { get; set; }
        public string StackTrace { get; set; }
        public string Status { get; set; }
    }
}
