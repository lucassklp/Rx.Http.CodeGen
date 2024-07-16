using Newtonsoft.Json;

namespace Codacy.Models
{
    public class FileDiffCoverage
    {
        [JsonProperty("fileName")]
        public string FileName { get; set; }
        [JsonProperty("coverage")]
        public double Coverage { get; set; }
        [JsonProperty("variation")]
        public double Variation { get; set; }
        [JsonProperty("diff")]
        public DiffCoverage Diff { get; set; }
        [JsonProperty("diffLineHits")]
        public List<DiffLineHit> DiffLineHits { get; set; }
    }
}
