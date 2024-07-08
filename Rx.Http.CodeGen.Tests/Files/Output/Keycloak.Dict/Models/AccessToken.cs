namespace Keycloak.Dict.Models
{
    public class AccessToken
    {
        public string Jti { get; set; }
        public int Exp { get; set; }
        public int Nbf { get; set; }
        public int Iat { get; set; }
        public string Iss { get; set; }
        public string Sub { get; set; }
        public string Typ { get; set; }
        public string Azp { get; set; }
        public Dictionary<string, object> OtherClaims { get; set; }
        public string Nonce { get; set; }
        public int AuthTime { get; set; }
        public string SessionState { get; set; }
        public string AtHash { get; set; }
        public string CHash { get; set; }
        public string Name { get; set; }
        public string GivenName { get; set; }
        public string FamilyName { get; set; }
        public string MiddleName { get; set; }
        public string Nickname { get; set; }
        public string PreferredUsername { get; set; }
        public string Profile { get; set; }
        public string Picture { get; set; }
        public string Website { get; set; }
        public string Email { get; set; }
        public bool EmailVerified { get; set; }
        public string Gender { get; set; }
        public string Birthdate { get; set; }
        public string Zoneinfo { get; set; }
        public string Locale { get; set; }
        public string PhoneNumber { get; set; }
        public bool PhoneNumberVerified { get; set; }
        public AddressClaimSet Address { get; set; }
        public int UpdatedAt { get; set; }
        public string ClaimsLocales { get; set; }
        public string Acr { get; set; }
        public string SHash { get; set; }
        public string Sid { get; set; }
        public List<string> TrustedCerts { get; set; }
        public List<string> AllowedOrigins { get; set; }
        public Access RealmAccess { get; set; }
        public Dictionary<string, object> ResourceAccess { get; set; }
        public Authorization Authorization { get; set; }
        public CertConf Cnf { get; set; }
        public string Scope { get; set; }
    }
}
