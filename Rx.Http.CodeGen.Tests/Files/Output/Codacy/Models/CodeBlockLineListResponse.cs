using Newtonsoft.Json;

namespace Codacy.Models
{
    public class CodeBlockLineListResponse
    {
        [JsonProperty("data")]
        public List<CodeBlockLine> Data { get; set; }
    }
}
