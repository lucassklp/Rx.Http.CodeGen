using Newtonsoft.Json;

namespace DocuSign.Models
{
    public class UpdateUsersRequest
    {
        [JsonProperty("users")]
        public List<UpdateUserRequest> Users { get; set; }
    }
}
