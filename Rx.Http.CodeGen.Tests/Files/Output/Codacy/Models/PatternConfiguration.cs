namespace Codacy.Models
{
    public class PatternConfiguration
    {
        public string Id { get; set; }
        public bool Enabled { get; set; }
        public List<ConfiguredParameter> Parameters { get; set; }
    }
}
