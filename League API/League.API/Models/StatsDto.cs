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

namespace League.API.Models
{
    public class StatsDto
    {
        [JsonProperty(PropertyName = "armorperlevel")]
        public double ArmorPerLevel { get; set; }

        [JsonProperty(PropertyName = "hpperlevel")]
        public double HPPerLevel { get; set; }

        [JsonProperty(PropertyName = "attackdamage")]
        public double AttackDamage { get; set; }

        [JsonProperty(PropertyName = "mpperlevel")]
        public double MPPerLevel { get; set; }

        [JsonProperty(PropertyName = "attackspeedoffset")]
        public double AttackSpeedOffset { get; set; }

        [JsonProperty(PropertyName = "armor")]
        public double Armor { get; set; }

        [JsonProperty(PropertyName = "hp")]
        public double HP { get; set; }

        [JsonProperty(PropertyName = "hpregenperlevel")]
        public double HPRegenPerLevel { get; set; }

        [JsonProperty(PropertyName = "spellblock")]
        public double SpellBlock { get; set; }

        [JsonProperty(PropertyName = "attackrange")]
        public double AttackRange { get; set; }

        [JsonProperty(PropertyName = "movespeed")]
        public double MoveSpeed { get; set; }

        [JsonProperty(PropertyName = "attackdamageperlevel")]
        public double AttackDamagePerLevel { get; set; }

        [JsonProperty(PropertyName = "mpregenperlevel")]
        public double MPRegenPerLevel { get; set; }

        [JsonProperty(PropertyName = "mp")]
        public double MP { get; set; }

        [JsonProperty(PropertyName = "spellblockperlevel")]
        public double SpellblockPerLevel { get; set; }

        [JsonProperty(PropertyName = "crit")]
        public double Crit { get; set; }

        [JsonProperty(PropertyName = "mpregen")]
        public double MPRegen { get; set; }

        [JsonProperty(PropertyName = "attackspeedperlevel")]
        public double AttackSpeedPerLevel { get; set; }

        [JsonProperty(PropertyName = "hpregen")]
        public double HPRegen { get; set; }

        [JsonProperty(PropertyName = "critperlevel")]
        public double CritPerLevel { get; set; }
    }
}
