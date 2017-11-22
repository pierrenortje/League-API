using RestSharp.Deserializers;
using System.Collections.Generic;

namespace League.API.Models
{
    public class Perks
    {
        /// <summary>
        /// Primary runes path.
        /// </summary>
        [DeserializeAs(Name = "perkStyle")]
        public long PerkStyle { get; set; }

        /// <summary>
        /// IDs of the perks/runes assigned.
        /// </summary>
        [DeserializeAs(Name = "perkIds")]
        public List<long> PerkIds { get; set; }

        /// <summary>
        /// Secondary runes path.
        /// </summary>
        [DeserializeAs(Name = "perkSubStyle")]
        public long PerkSubStyle { get; set; }
    }
}
