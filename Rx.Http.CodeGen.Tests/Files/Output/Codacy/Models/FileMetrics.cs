using Newtonsoft.Json;

namespace Codacy.Models
{
    public class FileMetrics
    {
        [JsonProperty("linesOfCode")]
        public int LinesOfCode { get; set; }
        [JsonProperty("commentedLinesOfCode")]
        public int CommentedLinesOfCode { get; set; }
        [JsonProperty("numberOfMethods")]
        public int NumberOfMethods { get; set; }
        [JsonProperty("numberOfClasses")]
        public int NumberOfClasses { get; set; }
    }
}
