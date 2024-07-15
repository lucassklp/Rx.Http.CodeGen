using Newtonsoft.Json;

namespace Codacy.Models
{
    public class FileClone
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("occurrences")]
        public List<CloneDuplicationBlock> Occurrences { get; set; }
    }
}
