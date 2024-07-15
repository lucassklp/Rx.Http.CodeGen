using Newtonsoft.Json;

namespace Codacy.Models
{
    public class FileDeltaAnalysis
    {
        [JsonProperty("file")]
        public FileMetadata File { get; set; }
        [JsonProperty("coverage")]
        public FileDeltaCoverageAnalysis Coverage { get; set; }
        [JsonProperty("quality")]
        public FileDeltaQualityAnalysis Quality { get; set; }
        [JsonProperty("comparedWithCommit")]
        public object ComparedWithCommit { get; set; }
    }
}
