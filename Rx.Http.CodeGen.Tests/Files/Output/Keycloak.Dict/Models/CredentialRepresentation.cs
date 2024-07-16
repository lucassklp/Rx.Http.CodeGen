using Newtonsoft.Json;

namespace Keycloak.Dict.Models
{
    public class CredentialRepresentation
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("userLabel")]
        public string UserLabel { get; set; }
        [JsonProperty("createdDate")]
        public int CreatedDate { get; set; }
        [JsonProperty("secretData")]
        public string SecretData { get; set; }
        [JsonProperty("credentialData")]
        public string CredentialData { get; set; }
        [JsonProperty("priority")]
        public int Priority { get; set; }
        [JsonProperty("value")]
        public string Value { get; set; }
        [JsonProperty("temporary")]
        public bool Temporary { get; set; }
        [JsonProperty("device")]
        public string Device { get; set; }
        [JsonProperty("hashedSaltedValue")]
        public string HashedSaltedValue { get; set; }
        [JsonProperty("salt")]
        public string Salt { get; set; }
        [JsonProperty("hashIterations")]
        public int HashIterations { get; set; }
        [JsonProperty("counter")]
        public int Counter { get; set; }
        [JsonProperty("algorithm")]
        public string Algorithm { get; set; }
        [JsonProperty("digits")]
        public int Digits { get; set; }
        [JsonProperty("period")]
        public int Period { get; set; }
        [JsonProperty("config")]
        public Dictionary<string, object> Config { get; set; }
    }
}
