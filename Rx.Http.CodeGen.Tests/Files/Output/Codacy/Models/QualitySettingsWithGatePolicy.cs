namespace Codacy.Models
{
    public class QualitySettingsWithGatePolicy
    {
        public QualityGate QualityGate { get; set; }
        public RepositoryGatePolicy RepositoryGatePolicyInfo { get; set; }
    }
}
