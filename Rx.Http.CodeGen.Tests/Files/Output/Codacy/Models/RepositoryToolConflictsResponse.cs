using Newtonsoft.Json;

namespace Codacy.Models
{
    public class RepositoryToolConflictsResponse
    {
        [JsonProperty("data")]
        public List<StandardPatternConflict> Data { get; set; }
    }
}
