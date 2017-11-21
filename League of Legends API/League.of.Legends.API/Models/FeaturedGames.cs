using RestSharp.Deserializers;
using System.Collections.Generic;

namespace League.of.Legends.API.Models
{
    public class FeaturedGames
    {
        /// <summary>
        /// The suggested interval to wait before requesting FeaturedGames again.
        /// </summary>
        [DeserializeAs(Name = "clientRefreshInterval")]
        public long ClientRefreshInterval { get; set; }

        /// <summary>
        /// The list of featured games.
        /// </summary>
        [DeserializeAs(Name = "gameList")]
        public FeaturedGamesList GameList { get; set; }
    }
    public class FeaturedGamesList : List<CurrentGameInfo> { }
}
