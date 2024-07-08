namespace Codacy.Models
{
    public class ConfiguredPattern
    {
        public Pattern PatternDefinition { get; set; }
        public bool Enabled { get; set; }
        public List<ConfiguredParameter> Parameters { get; set; }
    }
}
