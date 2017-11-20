using RestSharp.Deserializers;
using System.Collections.Generic;

namespace League.of.Legends.API.Models
{
    public class Champion
    {
        /// <summary>
        /// Ranked play enabled flag.
        /// </summary>
        [DeserializeAs(Name = "rankedPlayEnabled")]
        public bool RankedPlayEnabled { get; set; }

        /// <summary>
        /// Bot enabled flag (for custom games).
        /// </summary>
        [DeserializeAs(Name = "botEnabled")]
        public bool BotEnabled { get; set; }

        /// <summary>
        /// Bot Match Made enabled flag (for Co-op vs. AI games).
        /// </summary>
        [DeserializeAs(Name = "botMmEnabled")]
        public bool BotMmEnabled { get; set; }

        /// <summary>
        /// Indicates if the champion is active.
        /// </summary>
        [DeserializeAs(Name = "active")]
        public bool Active { get; set; }

        /// <summary>
        /// Indicates if the champion is free to play. Free to play champions are rotated periodically.
        /// </summary>
        [DeserializeAs(Name = "freeToPlay")]
        public bool FreeToPlay { get; set; }

        /// <summary>
        /// Champion ID. For static information correlating to champion IDs, please refer to the LoL Static Data API.
        /// </summary>
        [DeserializeAs(Name = "id")]
        public int ID { get; set; }
    }

    public class ChampionData
    {
        [DeserializeAs(Name = "champions")]
        public List<Champion> Champions { get; set; }
    }
}
