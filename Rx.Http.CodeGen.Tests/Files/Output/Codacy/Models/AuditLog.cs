using Newtonsoft.Json;

namespace Codacy.Models
{
    public class AuditLog
    {
        [JsonProperty("actor")]
        public AuditActor Actor { get; set; }
        [JsonProperty("action")]
        public string Action { get; set; }
        [JsonProperty("result")]
        public string Result { get; set; }
        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
        [JsonProperty("source")]
        public string Source { get; set; }
        [JsonProperty("repositoryName")]
        public string RepositoryName { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("details")]
        public object Details { get; set; }
        [JsonProperty("entityId")]
        public string EntityId { get; set; }
    }
}
