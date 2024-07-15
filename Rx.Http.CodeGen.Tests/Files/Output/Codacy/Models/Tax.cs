using Newtonsoft.Json;

namespace Codacy.Models
{
    public class Tax
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("rate")]
        public double Rate { get; set; }
    }
}
