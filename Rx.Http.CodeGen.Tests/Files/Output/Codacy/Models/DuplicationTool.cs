using Newtonsoft.Json;

namespace Codacy.Models
{
    public class DuplicationTool
    {
        [JsonProperty("dockerImage")]
        public string DockerImage { get; set; }
        [JsonProperty("languages")]
        public List<string> Languages { get; set; }
    }
}
