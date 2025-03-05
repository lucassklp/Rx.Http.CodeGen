using Newtonsoft.Json;

namespace Codacy.Models
{
    public class CommitUuidRequest
    {
        [JsonProperty("commitUuid")]
        public string CommitUuid { get; set; }
        [JsonProperty("cleanCache")]
        public bool CleanCache { get; set; }
    }
}
