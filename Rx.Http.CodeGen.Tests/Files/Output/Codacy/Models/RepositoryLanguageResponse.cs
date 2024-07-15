using Newtonsoft.Json;

namespace Codacy.Models
{
    public class RepositoryLanguageResponse
    {
        [JsonProperty("languages")]
        public List<RepositoryLanguage> Languages { get; set; }
    }
}
