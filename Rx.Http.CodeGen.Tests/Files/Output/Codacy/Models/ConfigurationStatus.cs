namespace Codacy.Models
{
    public class ConfigurationStatus
    {
        public string Title { get; set; }
        public string Category { get; set; }
        public List<string> Errors { get; set; }
        public string Link { get; set; }
    }
}
