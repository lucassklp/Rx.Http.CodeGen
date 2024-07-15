using Newtonsoft.Json;

namespace Codacy.Models
{
    public class GetFileCoverageResponse
    {
        [JsonProperty("data")]
        public List<FileCoverage> Data { get; set; }
    }
}
