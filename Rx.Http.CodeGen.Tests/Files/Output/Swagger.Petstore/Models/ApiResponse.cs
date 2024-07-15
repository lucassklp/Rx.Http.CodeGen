using Newtonsoft.Json;

namespace Swagger.Petstore.Models
{
    public class ApiResponse
    {
        [JsonProperty("code")]
        public int Code { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("message")]
        public string Message { get; set; }
    }
}
