namespace Codacy.Models
{
    public class FileClonesResponse
    {
        public List<FileClone> Data { get; set; }
        public PaginationInfo Pagination { get; set; }
    }
}
