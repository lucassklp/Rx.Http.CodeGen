namespace Codacy.Models
{
    public class HeartbeatResponse
    {
        public string LastActivity { get; set; }
        public int IdleExpiresIn { get; set; }
        public int AbsoluteExpiresIn { get; set; }
    }
}
