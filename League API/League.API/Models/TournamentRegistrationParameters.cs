using RestSharp.Serializers;

namespace League.API.Models
{
    public class TournamentRegistrationParameters
    {
        /// <summary>
        /// The provider ID to specify the regional registered provider data to associate this tournament.
        /// </summary>
        [SerializeAs(Name = "providerId")]
        public int ProviderId { get; set; }

        /// <summary>
        /// The optional name of the tournament.
        /// </summary>
        [SerializeAs(Name = "name")]
        public string Name { get; set; }
    }
}
