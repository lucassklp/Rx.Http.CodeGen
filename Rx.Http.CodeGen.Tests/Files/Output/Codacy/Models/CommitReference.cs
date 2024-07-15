using Newtonsoft.Json;

namespace Codacy.Models
{
    public class CommitReference
    {
        [JsonProperty("sha")]
        public string Sha { get; set; }
        [JsonProperty("commiter")]
        public string Commiter { get; set; }
        [JsonProperty("commiterName")]
        public string CommiterName { get; set; }
        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }
}
