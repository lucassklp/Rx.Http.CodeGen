namespace Codacy.Models
{
    public class RepositoryLanguage
    {
        public string Name { get; set; }
        public List<string> CodacyDefaults { get; set; }
        public List<string> Extensions { get; set; }
        public bool Enabled { get; set; }
        public bool Detected { get; set; }
    }
}
