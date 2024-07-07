namespace Codacy.Models
{
    public class RemovePeopleResponse
    {
        public List<RemovePeopleEmailStatus> Success { get; set; }
        public List<RemovePeopleEmailStatus> Failed { get; set; }
    }
}
