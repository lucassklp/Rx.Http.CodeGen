using Newtonsoft.Json;

namespace Codacy.Models
{
    public class FileMetadata
    {
        [JsonProperty("branchId")]
        public int BranchId { get; set; }
        [JsonProperty("commitId")]
        public int CommitId { get; set; }
        [JsonProperty("commitSha")]
        public string CommitSha { get; set; }
        [JsonProperty("fileId")]
        public int FileId { get; set; }
        [JsonProperty("fileDataId")]
        public int FileDataId { get; set; }
        [JsonProperty("path")]
        public string Path { get; set; }
        [JsonProperty("language")]
        public string Language { get; set; }
        [JsonProperty("gitProviderUrl")]
        public string GitProviderUrl { get; set; }
        [JsonProperty("ignored")]
        public bool Ignored { get; set; }
    }
}
