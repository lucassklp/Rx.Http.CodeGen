using Newtonsoft.Json;

namespace Codacy.Models
{
    public class DiffResponse
    {
        [JsonProperty("diff")]
        public string Diff { get; set; }
    }
}
