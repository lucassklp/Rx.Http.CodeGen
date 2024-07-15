using Newtonsoft.Json;

namespace Codacy.Models
{
    public class Unauthorized
    {
        [JsonProperty("message")]
        public string Message { get; set; }
        [JsonProperty("innerMessage")]
        public string InnerMessage { get; set; }
        [JsonProperty("actions")]
        public List<ProblemLink> Actions { get; set; }
        [JsonProperty("error")]
        public string Error { get; set; }
        [JsonProperty("code")]
        public string Code { get; set; }
    }
}
