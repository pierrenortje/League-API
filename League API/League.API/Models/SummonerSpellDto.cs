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
    public class SummonerSpellDto
    {
        [JsonProperty(PropertyName = "vars")]
        public SpellVarsDtoList Vars { get; set; }

        [JsonProperty(PropertyName = "image")]
        public ImageDto Image { get; set; }

        [JsonProperty(PropertyName = "costBurn")]
        public string CostBurn { get; set; }

        [JsonProperty(PropertyName = "cooldown")]
        public List<double> Cooldown { get; set; }

        [JsonProperty(PropertyName = "effectBurn")]
        public List<string> EffectBurn { get; set; }

        [JsonProperty(PropertyName = "id")]
        public int ID { get; set; }

        [JsonProperty(PropertyName = "cooldownBurn")]
        public string CooldownBurn { get; set; }

        [JsonProperty(PropertyName = "tooltip")]
        public string Tooltip { get; set; }

        [JsonProperty(PropertyName = "maxrank")]
        public int Maxrank { get; set; }

        [JsonProperty(PropertyName = "rangeBurn")]
        public string RangeBurn { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// This field is a List of List of Double.
        /// </summary>
        [JsonProperty(PropertyName = "effect")]
        public List<object> Effect { get; set; }

        [JsonProperty(PropertyName = "key")]
        public string Key { get; set; }

        [JsonProperty(PropertyName = "leveltip")]
        public LevelTipDto Leveltip { get; set; }

        [JsonProperty(PropertyName = "modes")]
        public List<string> Modes { get; set; }

        [JsonProperty(PropertyName = "resource")]
        public string Resource { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "costType")]
        public string CostType { get; set; }

        [JsonProperty(PropertyName = "sanitizedDescription")]
        public string SanitizedDescription { get; set; }

        [JsonProperty(PropertyName = "sanitizedTooltip")]
        public string SanitizedTooltip { get; set; }

        /// <summary>
        /// This field is either a List of Integer or the String
        /// 'self' for spells that target one's own champion.
        /// </summary>
        [JsonProperty(PropertyName = "range")]
        public object Range { get; set; }

        [JsonProperty(PropertyName = "cost")]
        public List<int> Cost { get; set; }

        [JsonProperty(PropertyName = "summonerLevel")]
        public int SummonerLevel { get; set; }
    }
}
