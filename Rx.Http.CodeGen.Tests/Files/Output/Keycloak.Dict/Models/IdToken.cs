using Newtonsoft.Json;

namespace Keycloak.Dict.Models
{
    public class IdToken
    {
        [JsonProperty("jti")]
        public string Jti { get; set; }
        [JsonProperty("exp")]
        public int Exp { get; set; }
        [JsonProperty("nbf")]
        public int Nbf { get; set; }
        [JsonProperty("iat")]
        public int Iat { get; set; }
        [JsonProperty("iss")]
        public string Iss { get; set; }
        [JsonProperty("sub")]
        public string Sub { get; set; }
        [JsonProperty("typ")]
        public string Typ { get; set; }
        [JsonProperty("azp")]
        public string Azp { get; set; }
        [JsonProperty("otherClaims")]
        public Dictionary<string, object> OtherClaims { get; set; }
        [JsonProperty("nonce")]
        public string Nonce { get; set; }
        [JsonProperty("authTime")]
        public int AuthTime { get; set; }
        [JsonProperty("session_state")]
        public string SessionState { get; set; }
        [JsonProperty("at_hash")]
        public string AtHash { get; set; }
        [JsonProperty("c_hash")]
        public string CHash { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("given_name")]
        public string GivenName { get; set; }
        [JsonProperty("family_name")]
        public string FamilyName { get; set; }
        [JsonProperty("middle_name")]
        public string MiddleName { get; set; }
        [JsonProperty("nickname")]
        public string Nickname { get; set; }
        [JsonProperty("preferred_username")]
        public string PreferredUsername { get; set; }
        [JsonProperty("profile")]
        public string Profile { get; set; }
        [JsonProperty("picture")]
        public string Picture { get; set; }
        [JsonProperty("website")]
        public string Website { get; set; }
        [JsonProperty("email")]
        public string Email { get; set; }
        [JsonProperty("email_verified")]
        public bool EmailVerified { get; set; }
        [JsonProperty("gender")]
        public string Gender { get; set; }
        [JsonProperty("birthdate")]
        public string Birthdate { get; set; }
        [JsonProperty("zoneinfo")]
        public string Zoneinfo { get; set; }
        [JsonProperty("locale")]
        public string Locale { get; set; }
        [JsonProperty("phone_number")]
        public string PhoneNumber { get; set; }
        [JsonProperty("phone_number_verified")]
        public bool PhoneNumberVerified { get; set; }
        [JsonProperty("address")]
        public AddressClaimSet Address { get; set; }
        [JsonProperty("updated_at")]
        public int UpdatedAt { get; set; }
        [JsonProperty("claims_locales")]
        public string ClaimsLocales { get; set; }
        [JsonProperty("acr")]
        public string Acr { get; set; }
        [JsonProperty("s_hash")]
        public string SHash { get; set; }
        [JsonProperty("sid")]
        public string Sid { get; set; }
    }
}
