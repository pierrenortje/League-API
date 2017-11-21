using RestSharp.Deserializers;

namespace League.of.Legends.API.Models
{
    public class SummonerDto
    {
        /// <summary>
        /// ID of the summoner icon associated with the summoner.
        /// </summary>
        [DeserializeAs(Name = "profileIconId")]
        public int ProfileIconId { get; set; }

        /// <summary>
        /// Summoner name.
        /// </summary>
        [DeserializeAs(Name = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Summoner level associated with the summoner.
        /// </summary>
        [DeserializeAs(Name = "summonerLevel")]
        public long SummonerLevel { get; set; }

        /// <summary>
        /// Date summoner was last modified specified as epoch milliseconds.
        /// The following events will update this timestamp: profile icon change,
        /// playing the tutorial or advanced tutorial, finishing a game, summoner name change.
        /// </summary>
        [DeserializeAs(Name = "revisionDate")]
        public long RevisionDate { get; set; }

        /// <summary>
        /// Summoner ID.
        /// </summary>
        [DeserializeAs(Name = "id")]
        public long ID { get; set; }

        /// <summary>
        /// Account ID.
        /// </summary>
        [DeserializeAs(Name = "accountId")]
        public long AccountId { get; set; }
    }
}
