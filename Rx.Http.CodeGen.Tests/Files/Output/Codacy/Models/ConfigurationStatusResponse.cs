namespace Codacy.Models
{
    public class ConfigurationStatusResponse
    {
        public List<ConfigurationStatus> Statuses { get; set; }
        public object Metadata { get; set; }
    }
}
