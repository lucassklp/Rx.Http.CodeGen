using Newtonsoft.Json;

namespace Codacy.Models
{
    public class RepositoryLanguagesBody
    {
        [JsonProperty("languages")]
        public List<RepositoryLanguageUpdate> Languages { get; set; }
    }
}
