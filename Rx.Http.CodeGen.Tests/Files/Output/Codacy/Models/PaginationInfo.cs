namespace Codacy.Models
{
    public class PaginationInfo
    {
        public string Cursor { get; set; }
        public int Limit { get; set; }
        public int Total { get; set; }
    }
}
