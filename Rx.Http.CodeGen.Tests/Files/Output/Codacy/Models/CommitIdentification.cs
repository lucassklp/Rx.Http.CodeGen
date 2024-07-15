using Newtonsoft.Json;

namespace Codacy.Models
{
    public class CommitIdentification
    {
        [JsonProperty("sha")]
        public string Sha { get; set; }
    }
}
