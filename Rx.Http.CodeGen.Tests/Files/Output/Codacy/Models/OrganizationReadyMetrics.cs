using Newtonsoft.Json;

namespace Codacy.Models
{
    public class OrganizationReadyMetrics
    {
        [JsonProperty("organizationId")]
        public int OrganizationId { get; set; }
        [JsonProperty("provider")]
        public string Provider { get; set; }
        [JsonProperty("organizationName")]
        public string OrganizationName { get; set; }
        [JsonProperty("readyMetrics")]
        public List<string> ReadyMetrics { get; set; }
        [JsonProperty("startedAt")]
        public string StartedAt { get; set; }
    }
}
