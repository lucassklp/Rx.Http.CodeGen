namespace Codacy.Models
{
    public class ConfigurePattern
    {
        public string Id { get; set; }
        public bool Enabled { get; set; }
        public List<ConfiguredParameter> Parameters { get; set; }
    }
}
