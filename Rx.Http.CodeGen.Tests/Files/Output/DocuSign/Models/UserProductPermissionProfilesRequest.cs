namespace DocuSign.Models
{
    public class UserProductPermissionProfilesRequest
    {
        public string Email { get; set; }
        public List<ProductPermissionProfileRequest> ProductPermissionProfiles { get; set; }
    }
}
