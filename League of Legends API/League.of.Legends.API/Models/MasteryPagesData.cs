using RestSharp.Deserializers;
using System.Collections.Generic;

namespace League.of.Legends.API.Models
{
    public class MasteryPagesData
    {
        /// <summary>
        /// Collection of mastery pages associated with the summoner.
        /// </summary>
        [DeserializeAs(Name = "pages")]
        public MasteryPages Pages { get; set; }

        /// <summary>
        /// Summoner ID.
        /// </summary>
        [DeserializeAs(Name = "summonerId")]
        public long SummonerId { get; set; }
    }

    public class MasteryPage
    {
        /// <summary>
        /// Indicates if the mastery page is the current mastery page.
        /// </summary>
        [DeserializeAs(Name = "current")]
        public bool Current { get; set; }

        /// <summary>
        /// Collection of masteries associated with the mastery page.
        /// </summary>
        [DeserializeAs(Name = "masteries")]
        public Masteries Masteries { get; set; }

        /// <summary>
        /// Mastery page name.
        /// </summary>
        [DeserializeAs(Name = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Mastery page ID.
        /// </summary>
        [DeserializeAs(Name = "id")]
        public long ID { get; set; }
    }
    public class MasteryPages : List<MasteryPage> { }

    public class Mastery
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
    public class Masteries : List<Mastery> { }
}
