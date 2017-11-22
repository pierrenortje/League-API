#region License
// Copyright (c) 2017 Pierre Nortje
//
// Permission is hereby granted, free of charge, to any person
// obtaining a copy of this software and associated documentation
// files (the "Software"), to deal in the Software without
// restriction, including without limitation the rights to use,
// copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the
// Software is furnished to do so, subject to the following
// conditions:
//
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
#endregion

using RestSharp.Deserializers;
using System.Collections.Generic;

namespace League.API.Models
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
