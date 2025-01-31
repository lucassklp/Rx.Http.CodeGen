using Newtonsoft.Json;

namespace Codacy.Models
{
    public class CommitDetailsV2
    {
        [JsonProperty("commit")]
        public Commit Commit { get; set; }
        [JsonProperty("repository")]
        public RepositoryIdentificationV2 Repository { get; set; }
    }
}
