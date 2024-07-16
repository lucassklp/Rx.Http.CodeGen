using Newtonsoft.Json;

namespace Codacy.Models
{
    public class UserBody
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("shouldDoClientQualification")]
        public bool ShouldDoClientQualification { get; set; }
    }
}
