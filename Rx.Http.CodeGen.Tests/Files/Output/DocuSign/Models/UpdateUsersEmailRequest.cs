using Newtonsoft.Json;

namespace DocuSign.Models
{
    public class UpdateUsersEmailRequest
    {
        [JsonProperty("users")]
        public List<UpdateUserEmailRequest> Users { get; set; }
    }
}
