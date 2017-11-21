using RestSharp.Deserializers;
using System.Collections.Generic;

namespace League.of.Legends.API.Models
{
    public class CurrentGameParticipant
    {
        /// <summary>
        /// The ID of the profile icon used by this participant.
        /// </summary>
        [DeserializeAs(Name = "profileIconId")]
        public long ProfileIconId { get; set; }

        /// <summary>
        /// The ID of the champion played by this participant.
        /// </summary>
        [DeserializeAs(Name = "championId")]
        public long ChampionId { get; set; }

        /// <summary>
        /// The summoner name of this participant.
        /// </summary>
        [DeserializeAs(Name = "summonerName")]
        public string SummonerName { get; set; }

        /// <summary>
        /// List of Game Customizations.
        /// </summary>
        [DeserializeAs(Name = "gameCustomizationObjects")]
        public GameCustomizationObjects GameCustomizationObjects { get; set; }

        /// <summary>
        /// Flag indicating whether or not this participant is a bot.
        /// </summary>
        [DeserializeAs(Name = "bot")]
        public bool Bot { get; set; }

        /// <summary>
        /// Perks/Runes Reforged Information.
        /// </summary>
        [DeserializeAs(Name = "perks")]
        public Perks Perks { get; set; }

        /// <summary>
        /// The ID of the second summoner spell used by this participant.
        /// </summary>
        [DeserializeAs(Name = "spell2Id")]
        public long Spell2Id { get; set; }

        /// <summary>
        /// The team ID of this participant, indicating the participant's team.
        /// </summary>
        [DeserializeAs(Name = "teamId")]
        public long TeamId { get; set; }

        /// <summary>
        /// The ID of the first summoner spell used by this participant.
        /// </summary>
        [DeserializeAs(Name = "spell1Id")]
        public long Spell1Id { get; set; }

        /// <summary>
        /// The summoner ID of this participant.
        /// </summary>
        [DeserializeAs(Name = "summonerId")]
        public long SummonerId { get; set; }
    }
    public class CurrentGameParticipants : List<CurrentGameParticipant> { }
}
