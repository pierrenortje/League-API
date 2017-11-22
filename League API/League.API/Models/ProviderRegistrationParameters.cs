using RestSharp.Serializers;

namespace League.API.Models
{
    public class ProviderRegistrationParameters
    {
        /// <summary>
        /// The provider's callback URL to which tournament game results in this region
        /// should be posted. The URL must be well-formed, use the http or https protocol,
        /// and use the default port for the protocol (http URLs must use port 80, https URLs
        /// must use port 443).
        /// </summary>
        [SerializeAs(Name = "url")]
        public string Url { get; set; }

        /// <summary>
        /// The region in which the provider will be running tournaments.
        /// (Legal values: BR, EUNE, EUW, JP, LAN, LAS, NA, OCE, PBE, RU, TR).
        /// </summary>
        [SerializeAs(Name = "region")]
        public string Region { get; set; }
    }
}
