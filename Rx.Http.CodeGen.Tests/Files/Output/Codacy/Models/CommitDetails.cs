using Newtonsoft.Json;

namespace Codacy.Models
{
    public class CommitDetails
    {
        [JsonProperty("commit")]
        public Commit Commit { get; set; }
        [JsonProperty("repository")]
        public RepositoryIdentification Repository { get; set; }
    }
}
