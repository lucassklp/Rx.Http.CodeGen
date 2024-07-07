namespace Codacy.Models
{
    public class ApplyCodingStandardToRepositoriesResult
    {
        public List<string> Successful { get; set; }
        public List<string> Failed { get; set; }
    }
}
