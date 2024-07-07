namespace Codacy.Models
{
    public class AnalysisTool
    {
        public string Uuid { get; set; }
        public string Name { get; set; }
        public bool IsClientSide { get; set; }
        public AnalysisToolSettings Settings { get; set; }
    }
}
