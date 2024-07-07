namespace Codacy.Models
{
    public class CreateCodingStandardBody
    {
        public string Name { get; set; }
        public List<string> Languages { get; set; }
    }
}
