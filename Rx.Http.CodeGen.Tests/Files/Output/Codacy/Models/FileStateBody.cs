using Newtonsoft.Json;

namespace Codacy.Models
{
    public class FileStateBody
    {
        [JsonProperty("ignored")]
        public bool Ignored { get; set; }
        [JsonProperty("filepath")]
        public string Filepath { get; set; }
    }
}
