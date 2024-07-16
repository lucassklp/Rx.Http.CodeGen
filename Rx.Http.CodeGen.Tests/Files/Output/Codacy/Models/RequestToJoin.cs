using Newtonsoft.Json;

namespace Codacy.Models
{
    public class RequestToJoin
    {
        [JsonProperty("email")]
        public string Email { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("numberOfCommits")]
        public int NumberOfCommits { get; set; }
        [JsonProperty("numberOfRepositories")]
        public int NumberOfRepositories { get; set; }
        [JsonProperty("lastActivity")]
        public string LastActivity { get; set; }
        [JsonProperty("creationDate")]
        public string CreationDate { get; set; }
    }
}
