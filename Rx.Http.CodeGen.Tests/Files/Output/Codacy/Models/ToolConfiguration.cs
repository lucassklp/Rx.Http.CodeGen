namespace Codacy.Models
{
    public class ToolConfiguration
    {
        public bool Enabled { get; set; }
        public List<PatternConfiguration> Patterns { get; set; }
    }
}
