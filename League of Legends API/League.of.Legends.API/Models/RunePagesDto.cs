using RestSharp.Deserializers;

namespace League.of.Legends.API.Models
{
    public class RunePagesDto
    {
        /// <summary>
        /// Collection of rune pages associated with the summoner.
        /// </summary>
        [DeserializeAs(Name = "pages")]
        public RunePageDtoList Pages { get; set; }

        /// <summary>
        /// Summoner ID.
        /// </summary>
        [DeserializeAs(Name = "summonerId")]
        public long SummonerId { get; set; }
    }
}
