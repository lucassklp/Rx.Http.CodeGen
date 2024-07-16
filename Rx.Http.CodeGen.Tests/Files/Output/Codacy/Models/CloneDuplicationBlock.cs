using Newtonsoft.Json;

namespace Codacy.Models
{
    public class CloneDuplicationBlock
    {
        [JsonProperty("path")]
        public string Path { get; set; }
        [JsonProperty("fileId")]
        public int FileId { get; set; }
        [JsonProperty("fileDataId")]
        public int FileDataId { get; set; }
        [JsonProperty("fromLine")]
        public int FromLine { get; set; }
        [JsonProperty("toLine")]
        public int ToLine { get; set; }
    }
}
