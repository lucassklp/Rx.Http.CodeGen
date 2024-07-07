namespace Codacy.Models
{
    public class GatePolicy
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsDefault { get; set; }
        public bool ReadOnly { get; set; }
        public QualityGate Settings { get; set; }
        public GatePolicyMeta Meta { get; set; }
    }
}
