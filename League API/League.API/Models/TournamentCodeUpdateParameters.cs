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
    public class TournamentCodeUpdateParameters
    {
        /// <summary>
        /// The spectator type (Legal values: NONE, LOBBYONLY, ALL).
        /// </summary>
        [SerializeAs(Name = "spectatorType")]
        public string SpectatorType { get; set; }

        /// <summary>
        /// The pick type (Legal values: BLIND_PICK, DRAFT_MODE, ALL_RANDOM, TOURNAMENT_DRAFT).
        /// </summary>
        [SerializeAs(Name = "pickType")]
        public string PickType { get; set; }

        /// <summary>
        /// Comma separated list of summoner Ids.
        /// </summary>
        [SerializeAs(Name = "allowedParticipants")]
        public string AllowedParticipants { get; set; }

        /// <summary>
        /// The map type (Legal values: SUMMONERS_RIFT, TWISTED_TREELINE, HOWLING_ABYSS).
        /// </summary>
        [SerializeAs(Name = "mapType")]
        public string MapType { get; set; }
    }
}
