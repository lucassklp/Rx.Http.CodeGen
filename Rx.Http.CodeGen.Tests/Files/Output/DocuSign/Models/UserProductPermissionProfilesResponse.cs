namespace DocuSign.Models
{
    public class UserProductPermissionProfilesResponse
    {
        public string UserId { get; set; }
        public string AccountId { get; set; }
        public List<ProductPermissionProfileResponse> ProductPermissionProfiles { get; set; }
    }
}
