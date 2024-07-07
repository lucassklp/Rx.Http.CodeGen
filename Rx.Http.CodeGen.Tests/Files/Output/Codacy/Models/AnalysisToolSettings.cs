namespace Codacy.Models
{
    public class AnalysisToolSettings
    {
        public string Name { get; set; }
        public bool IsEnabled { get; set; }
        public bool HasConfigurationFile { get; set; }
        public bool UsesConfigurationFile { get; set; }
    }
}
