using Newtonsoft.Json;

namespace Codacy.Models
{
    public class ConfigurationStatusResponse
    {
        [JsonProperty("statuses")]
        public List<ConfigurationStatus> Statuses { get; set; }
        [JsonProperty("metadata")]
        public object Metadata { get; set; }
    }
}
