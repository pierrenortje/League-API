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

namespace League.API.Models
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
}
