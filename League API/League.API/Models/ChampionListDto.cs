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

using Newtonsoft.Json;
using System.Collections.Generic;

namespace League.API.Models
{
    public class ChampionListDto
    {
        [JsonProperty(PropertyName = "keys")]
        public Dictionary<string, string> Keys { get; set; }

        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        [JsonProperty(PropertyName = "version")]
        public string Version { get; set; }

        [JsonProperty(PropertyName = "data")]
        public Dictionary<string, ChampionDto> Data { get; set; }

        [JsonProperty(PropertyName = "format")]
        public string Format { get; set; }
    }

    public class ChampionDto
    {
        [JsonProperty(PropertyName = "info")]
        public InfoDto Info { get; set; }

        [JsonProperty(PropertyName = "enemytips")]
        public List<string> EnemyTips { get; set; }

        [JsonProperty(PropertyName = "stats")]
        public StatsDto Stats { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        [JsonProperty(PropertyName = "image")]
        public ImageDto Image { get; set; }

        [JsonProperty(PropertyName = "tags")]
        public List<string> Tags { get; set; }

        [JsonProperty(PropertyName = "partype")]
        public string ParType { get; set; }

        [JsonProperty(PropertyName = "skins")]
        public SkinDtoList Skins { get; set; }

        [JsonProperty(PropertyName = "passive")]
        public PassiveDto Passive { get; set; }

        [JsonProperty(PropertyName = "recommended")]
        public RecommendedDtoList RecommendedList { get; set; }

        [JsonProperty(PropertyName = "allytips")]
        public List<string> Allytips { get; set; }

        [JsonProperty(PropertyName = "key")]
        public string Key { get; set; }

        [JsonProperty(PropertyName = "lore")]
        public string Lore { get; set; }

        [JsonProperty(PropertyName = "id")]
        public int ID { get; set; }

        [JsonProperty(PropertyName = "blurb")]
        public string Blurb { get; set; }

        [JsonProperty(PropertyName = "spells")]
        public ChampionSpells Spells { get; set; }
    }
}
