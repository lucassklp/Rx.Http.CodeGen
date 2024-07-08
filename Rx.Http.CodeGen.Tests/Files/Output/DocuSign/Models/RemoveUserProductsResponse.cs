namespace DocuSign.Models
{
    public class RemoveUserProductsResponse
    {
        public bool IsSuccess { get; set; }
        public string UserEmail { get; set; }
        public string UserId { get; set; }
        public object UserProductResults { get; set; }
    }
}
