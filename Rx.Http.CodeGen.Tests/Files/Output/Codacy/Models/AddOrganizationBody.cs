namespace Codacy.Models
{
    public class AddOrganizationBody
    {
        public string Provider { get; set; }
        public string RemoteIdentifier { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public List<string> Products { get; set; }
    }
}
