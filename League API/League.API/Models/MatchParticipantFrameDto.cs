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
    public class MatchParticipantFrameDto
    {
        [DeserializeAs(Name = "totalGold")]
        public int TotalGold { get; set; }

        [DeserializeAs(Name = "teamScore")]
        public int TeamScore { get; set; }

        [DeserializeAs(Name = "participantId")]
        public int ParticipantId { get; set; }

        [DeserializeAs(Name = "level")]
        public int Level { get; set; }

        [DeserializeAs(Name = "currentGold")]
        public int CurrentGold { get; set; }

        [DeserializeAs(Name = "minionsKilled")]
        public int MinionsKilled { get; set; }

        [DeserializeAs(Name = "dominionScore")]
        public int DominionScore { get; set; }

        [DeserializeAs(Name = "position")]
        public MatchPositionDto Position { get; set; }

        [DeserializeAs(Name = "xp")]
        public int XP { get; set; }

        [DeserializeAs(Name = "jungleMinionsKilled")]
        public int JungleMinionsKilled { get; set; }
    }
}
