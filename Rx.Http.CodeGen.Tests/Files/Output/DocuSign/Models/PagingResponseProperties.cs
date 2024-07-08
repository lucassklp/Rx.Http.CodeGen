namespace DocuSign.Models
{
    public class PagingResponseProperties
    {
        public int ResultSetSize { get; set; }
        public int ResultSetStartPosition { get; set; }
        public int ResultSetEndPosition { get; set; }
        public int TotalSetSize { get; set; }
        public string Next { get; set; }
        public string Previous { get; set; }
    }
}
