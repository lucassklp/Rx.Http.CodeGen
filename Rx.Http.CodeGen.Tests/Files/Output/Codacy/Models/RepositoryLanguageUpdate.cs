namespace Codacy.Models
{
    public class RepositoryLanguageUpdate
    {
        public string Name { get; set; }
        public List<string> Extensions { get; set; }
        public bool Enabled { get; set; }
    }
}
