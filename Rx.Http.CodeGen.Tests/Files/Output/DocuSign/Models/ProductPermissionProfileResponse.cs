namespace DocuSign.Models
{
    public class ProductPermissionProfileResponse
    {
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public List<PermissionProfileResponse21> PermissionProfiles { get; set; }
        public string ErrorMessage { get; set; }
    }
}
