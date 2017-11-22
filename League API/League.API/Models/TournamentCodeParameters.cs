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

using RestSharp.Serializers;

namespace League.API.Models
{
    public class TournamentCodeParameters
    {
        /// <summary>
        /// The spectator type of the game. (Legal values: NONE, LOBBYONLY, ALL).
        /// </summary>
        [SerializeAs(Name = "spectatorType")]
        public string SpectatorType { get; set; }

        /// <summary>
        /// The team size of the game. Valid values are 1-5.
        /// </summary>
        [SerializeAs(Name = "teamSize")]
        public int TeamSize { get; set; }

        /// <summary>
        /// The pick type of the game. (Legal values: BLIND_PICK, DRAFT_MODE, ALL_RANDOM, TOURNAMENT_DRAFT).
        /// </summary>
        [SerializeAs(Name = "pickType")]
        public string PickType { get; set; }

        /// <summary>
        /// Optional list of participants in order to validate the players eligible to join the lobby.
        /// NOTE: We currently do not enforce participants at the team level, but rather the aggregate of
        /// teamOne and teamTwo. We may add the ability to enforce at the team level in the future.
        /// </summary>
        [SerializeAs(Name = "allowedSummonerIdstatorType")]
        public SummonerIdParams AllowedSummonerIds { get; set; }

        /// <summary>
        /// The map type of the game. (Legal values: SUMMONERS_RIFT, TWISTED_TREELINE, HOWLING_ABYSS).
        /// </summary>
        [SerializeAs(Name = "mapType")]
        public string MapType { get; set; }

        /// <summary>
        /// Optional string that may contain any data in any format, if specified at all.
        /// Used to denoteany custom information about the game.
        /// </summary>
        [SerializeAs(Name = "metadata")]
        public string Metadata { get; set; }
    }
}
