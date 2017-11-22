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
    public class ParticipantDto
    {
        [DeserializeAs(Name = "stats")]
        public ParticipantStats Stats { get; set; }

        [DeserializeAs(Name = "participantId")]
        public int ParticipantId { get; set; }

        [DeserializeAs(Name = "runes")]
        public RuneItemList Runes { get; set; }

        [DeserializeAs(Name = "timeline")]
        public ParticipantTimelineDto Timeline { get; set; }

        [DeserializeAs(Name = "teamId")]
        public int TeamId { get; set; }

        [DeserializeAs(Name = "spell2Id")]
        public int Spell2Id { get; set; }

        [DeserializeAs(Name = "masteries")]
        public Masteries Masteries { get; set; }

        [DeserializeAs(Name = "highestAchievedSeasonTier")]
        public string HighestAchievedSeasonTier { get; set; }

        [DeserializeAs(Name = "spell1Id")]
        public int Spell1Id { get; set; }

        [DeserializeAs(Name = "championId")]
        public int ChampionId { get; set; }
    }
    public class ParticipantDtoList : List<ParticipantDto> { }
}
