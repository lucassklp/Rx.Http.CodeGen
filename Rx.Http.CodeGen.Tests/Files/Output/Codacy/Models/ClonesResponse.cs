namespace Codacy.Models
{
    public class ClonesResponse
    {
        public List<CommitFileClone> Data { get; set; }
        public PaginationInfo Pagination { get; set; }
    }
}
