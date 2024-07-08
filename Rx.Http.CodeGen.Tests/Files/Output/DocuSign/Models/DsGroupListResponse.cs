namespace DocuSign.Models
{
    public class DsGroupListResponse
    {
        public int Page { get; set; }
        public int PageSize { get; set; }
        public int TotalCount { get; set; }
        public string AccountId { get; set; }
        public List<DsGroupResponse> DsGroups { get; set; }
    }
}
