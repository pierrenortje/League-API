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
