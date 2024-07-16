using Newtonsoft.Json;

namespace Codacy.Models
{
    public class CodeBlockLine
    {
        [JsonProperty("number")]
        public int Number { get; set; }
        [JsonProperty("content")]
        public string Content { get; set; }
    }
}
