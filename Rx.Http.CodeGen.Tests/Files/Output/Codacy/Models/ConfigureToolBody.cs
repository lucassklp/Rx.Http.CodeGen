namespace Codacy.Models
{
    public class ConfigureToolBody
    {
        public bool Enabled { get; set; }
        public bool UseConfigurationFile { get; set; }
        public List<ConfigurePattern> Patterns { get; set; }
    }
}
