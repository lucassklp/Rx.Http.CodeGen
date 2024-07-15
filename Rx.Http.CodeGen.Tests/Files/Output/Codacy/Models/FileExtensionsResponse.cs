using Newtonsoft.Json;

namespace Codacy.Models
{
    public class FileExtensionsResponse
    {
        [JsonProperty("languagesExtensions")]
        public List<FileExtensions> LanguagesExtensions { get; set; }
    }
}
