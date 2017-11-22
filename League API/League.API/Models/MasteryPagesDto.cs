using RestSharp.Deserializers;

namespace League.API.Models
{
    public class MasteryPagesDto
    {
        /// <summary>
        /// Collection of mastery pages associated with the summoner.
        /// </summary>
        [DeserializeAs(Name = "pages")]
        public MasteryPageDtoList Pages { get; set; }

        /// <summary>
        /// Summoner ID.
        /// </summary>
        [DeserializeAs(Name = "summonerId")]
        public long SummonerId { get; set; }
    }
}
