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
    public class MatchDto
    {
        [DeserializeAs(Name = "seasonId")]
        public int SeasonId { get; set; }

        [DeserializeAs(Name = "queueId")]
        public int QueueId { get; set; }

        [DeserializeAs(Name = "gameId")]
        public long GameId { get; set; }

        [DeserializeAs(Name = "participantIdentities")]
        public ParticipantIdentityDtoList ParticipantIdentities { get; set; }

        [DeserializeAs(Name = "gameVersion")]
        public string GameVersion { get; set; }

        [DeserializeAs(Name = "platformId")]
        public string PlatformId { get; set; }

        [DeserializeAs(Name = "gameMode")]
        public string GameMode { get; set; }

        [DeserializeAs(Name = "mapId")]
        public int MapId { get; set; }

        [DeserializeAs(Name = "gameType")]
        public string GameType { get; set; }

        [DeserializeAs(Name = "teams")]
        public TeamStatsDtoList Teams { get; set; }

        [DeserializeAs(Name = "participants")]
        public ParticipantDtoList Participants { get; set; }

        [DeserializeAs(Name = "gameDuration")]
        public long GameDuration { get; set; }

        [DeserializeAs(Name = "gameCreation")]
        public long GameCreation { get; set; }
    }
}
