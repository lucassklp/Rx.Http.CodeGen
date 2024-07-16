using Newtonsoft.Json;

namespace Codacy.Models
{
    public class IssueStateBody
    {
        [JsonProperty("ignored")]
        public bool Ignored { get; set; }
    }
}
