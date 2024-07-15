using Newtonsoft.Json;

namespace Codacy.Models
{
    public class LanguageListResponse
    {
        [JsonProperty("data")]
        public List<Language> Data { get; set; }
    }
}
