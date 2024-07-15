using Newtonsoft.Json;

namespace Codacy.Models
{
    public class ApiError
    {
        [JsonProperty("message")]
        public string Message { get; set; }
        [JsonProperty("innerMessage")]
        public string InnerMessage { get; set; }
        [JsonProperty("actions")]
        public List<ProblemLink> Actions { get; set; }
    }
}
