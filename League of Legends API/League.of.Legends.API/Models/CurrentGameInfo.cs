using RestSharp.Deserializers;
using System.Collections.Generic;

namespace League.of.Legends.API.Models
{
    public class CurrentGameInfo
    {
        /// <summary>
        /// The ID of the game.
        /// </summary>
        [DeserializeAs(Name = "gameId")]
        public long GameId { get; set; }

        /// <summary>
        /// The game start time represented in epoch milliseconds.
        /// </summary>
        [DeserializeAs(Name = "gameStartTime")]
        public long GameStartTime { get; set; }

        /// <summary>
        /// The ID of the platform on which the game is being played.
        /// </summary>
        [DeserializeAs(Name = "platformId")]
        public string PlatformId { get; set; }

        /// <summary>
        /// The game mode.
        /// </summary>
        [DeserializeAs(Name = "gameMode")]
        public string GameMode { get; set; }

        /// <summary>
        /// The ID of the map.
        /// </summary>
        [DeserializeAs(Name = "mapId")]
        public long MapId { get; set; }

        /// <summary>
        /// The game type.
        /// </summary>
        [DeserializeAs(Name = "gameType")]
        public string GameType { get; set; }

        /// <summary>
        /// Banned champion information.
        /// </summary>
        [DeserializeAs(Name = "bannedChampions")]
        public BannedChampions BannedChampions { get; set; }

        /// <summary>
        /// The observer information.
        /// </summary>
        [DeserializeAs(Name = "observers")]
        public Observer Observers { get; set; }

        /// <summary>
        /// The participant information.
        /// </summary>
        [DeserializeAs(Name = "participants")]
        public CurrentGameParticipants Participants { get; set; }

        /// <summary>
        /// The amount of time in seconds that has passed since the game started.
        /// </summary>
        [DeserializeAs(Name = "gameLength")]
        public long GameLength { get; set; }

        /// <summary>
        /// The queue type (queue types are documented on the Game Constants page).
        /// </summary>
        [DeserializeAs(Name = "gameQueueConfigId")]
        public long GameQueueConfigId { get; set; }
    }

    public class BannedChampion
    {
        /// <summary>
        /// The turn during which the champion was banned.
        /// </summary>
        [DeserializeAs(Name = "pickTurn")]
        public int PickTurn { get; set; }

        /// <summary>
        /// The ID of the banned champion.
        /// </summary>
        [DeserializeAs(Name = "championId")]
        public long ChampionId { get; set; }

        /// <summary>
        /// The ID of the team that banned the champion.
        /// </summary>
        [DeserializeAs(Name = "teamId")]
        public long TeamId { get; set; }
    }
    public class BannedChampions : List<BannedChampion> { }

    public class Observer
    {
        /// <summary>
        /// Key used to decrypt the spectator grid game data for playback.
        /// </summary>
        [DeserializeAs(Name = "encryptionKey")]
        public string EncryptionKey { get; set; }
    }

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

    public class GameCustomizationObject
    {
        /// <summary>
        /// Category identifier for Game Customization.
        /// </summary>
        [DeserializeAs(Name = "category")]
        public string Category { get; set; }

        /// <summary>
        /// Game Customization content.
        /// </summary>
        [DeserializeAs(Name = "content")]
        public string Content { get; set; }
    }
    public class GameCustomizationObjects : List<GameCustomizationObject> { }
}
