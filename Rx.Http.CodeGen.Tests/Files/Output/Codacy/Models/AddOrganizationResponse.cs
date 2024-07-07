namespace Codacy.Models
{
    public class AddOrganizationResponse
    {
        public Organization Organization { get; set; }
        public List<string> Warnings { get; set; }
    }
}
