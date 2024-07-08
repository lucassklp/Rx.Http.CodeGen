namespace Codacy.Models
{
    public class License
    {
        public int NumberOfSeats { get; set; }
        public string Email { get; set; }
        public string ExpirationDate { get; set; }
        public int InactivityThreshold { get; set; }
        public bool AutoAddAuthors { get; set; }
        public bool AllowSeatsOverflow { get; set; }
    }
}
