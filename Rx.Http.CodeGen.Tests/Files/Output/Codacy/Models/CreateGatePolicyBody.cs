namespace Codacy.Models
{
    public class CreateGatePolicyBody
    {
        public string GatePolicyName { get; set; }
        public bool IsDefault { get; set; }
        public QualityGate Settings { get; set; }
    }
}
