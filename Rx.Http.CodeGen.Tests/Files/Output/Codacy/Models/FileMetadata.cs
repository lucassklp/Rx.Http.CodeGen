namespace Codacy.Models
{
    public class FileMetadata
    {
        public int BranchId { get; set; }
        public int CommitId { get; set; }
        public string CommitSha { get; set; }
        public int FileId { get; set; }
        public int FileDataId { get; set; }
        public string Path { get; set; }
        public string Language { get; set; }
        public string GitProviderUrl { get; set; }
        public bool Ignored { get; set; }
    }
}
