namespace Codacy.Models
{
    public class ListPeopleResponse
    {
        public List<Person> Data { get; set; }
        public PaginationInfo Pagination { get; set; }
    }
}
