using Newtonsoft.Json;

namespace Codacy.Models
{
    public class CommitWithBranches
    {
        [JsonProperty("branches")]
        public List<Branch> Branches { get; set; }
    }
}
