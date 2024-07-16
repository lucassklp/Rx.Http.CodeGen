using Newtonsoft.Json;

namespace Codacy.Models
{
    public class License
    {
        [JsonProperty("numberOfSeats")]
        public int NumberOfSeats { get; set; }
        [JsonProperty("email")]
        public string Email { get; set; }
        [JsonProperty("expirationDate")]
        public string ExpirationDate { get; set; }
        [JsonProperty("inactivityThreshold")]
        public int InactivityThreshold { get; set; }
        [JsonProperty("autoAddAuthors")]
        public bool AutoAddAuthors { get; set; }
        [JsonProperty("allowSeatsOverflow")]
        public bool AllowSeatsOverflow { get; set; }
    }
}
