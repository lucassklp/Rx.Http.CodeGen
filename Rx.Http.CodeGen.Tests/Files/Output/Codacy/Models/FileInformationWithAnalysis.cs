using Newtonsoft.Json;

namespace Codacy.Models
{
    public class FileInformationWithAnalysis
    {
        [JsonProperty("file")]
        public FileMetadata File { get; set; }
        [JsonProperty("metrics")]
        public FileMetrics Metrics { get; set; }
        [JsonProperty("coverage")]
        public FileCoverageAnalysis Coverage { get; set; }
        [JsonProperty("quality")]
        public FileQualityInfo Quality { get; set; }
    }
}
