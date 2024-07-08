namespace Codacy.Models
{
    public class SlackIntegration
    {
        public int OrganizationId { get; set; }
        public string WebhookUrl { get; set; }
        public string CreatedAt { get; set; }
        public string UpdatedAt { get; set; }
    }
}
