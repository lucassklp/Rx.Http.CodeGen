using Newtonsoft.Json;

namespace Codacy.Models
{
    public class FileExtensionsBody
    {
        [JsonProperty("languagesExtensions")]
        public List<FileExtensionsUpdate> LanguagesExtensions { get; set; }
    }
}
