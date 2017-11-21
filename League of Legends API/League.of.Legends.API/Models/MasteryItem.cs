using RestSharp.Deserializers;
using System.Collections.Generic;

namespace League.of.Legends.API.Models
{
    public class MasteryItem
    {
        /// <summary>
        /// Mastery ID. For static information correlating to masteries,
        /// please refer to the LoL Static Data API.
        /// </summary>
        [DeserializeAs(Name = "id")]
        public int ID { get; set; }

        /// <summary>
        /// Mastery rank (i.e., the number of points put into this mastery).
        /// </summary>
        [DeserializeAs(Name = "rank")]
        public int Rank { get; set; }
    }
    public class Masteries : List<MasteryItem> { }
}
