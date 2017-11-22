using RestSharp.Serializers;
using System.Collections.Generic;

namespace League.API.Models
{
    public class SummonerIdParams
    {
        /// <summary>
        /// The tournament participants.
        /// </summary>
        [SerializeAs(Name = "participants")]
        public List<long> Participants { get; set; }
    }
}
