using Newtonsoft.Json;

namespace Codacy.Models
{
    public class RepositoryConflictsResponse
    {
        [JsonProperty("data")]
        public List<string> Data { get; set; }
    }
}
