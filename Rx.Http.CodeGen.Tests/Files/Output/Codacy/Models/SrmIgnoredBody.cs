using Newtonsoft.Json;

namespace Codacy.Models
{
    public class SrmIgnoredBody
    {
        [JsonProperty("at")]
        public string At { get; set; }
        [JsonProperty("authorId")]
        public int AuthorId { get; set; }
        [JsonProperty("authorName")]
        public string AuthorName { get; set; }
        [JsonProperty("reason")]
        public string Reason { get; set; }
    }
}
