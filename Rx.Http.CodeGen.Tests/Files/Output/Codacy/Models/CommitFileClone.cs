using Newtonsoft.Json;

namespace Codacy.Models
{
    public class CommitFileClone
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("status")]
        public string Status { get; set; }
        [JsonProperty("clones")]
        public List<CloneDuplicationBlock> Clones { get; set; }
    }
}
