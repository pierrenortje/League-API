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
    public class ItemDto
    {
        [JsonProperty(PropertyName = "gold")]
        public GoldDto Gold { get; set; }

        [JsonProperty(PropertyName = "plaintext")]
        public string PlainText { get; set; }

        [JsonProperty(PropertyName = "hideFromAll")]
        public bool HideFromAll { get; set; }

        [JsonProperty(PropertyName = "inStore")]
        public bool InStore { get; set; }

        [JsonProperty(PropertyName = "into")]
        public List<string> Into { get; set; }

        [JsonProperty(PropertyName = "id")]
        public int ID { get; set; }

        [JsonProperty(PropertyName = "stats")]
        public InventoryDataStatsDto Stats { get; set; }

        [JsonProperty(PropertyName = "colloq")]
        public string Colloq { get; set; }

        [JsonProperty(PropertyName = "maps")]
        public Dictionary<string, bool> Maps { get; set; }

        [JsonProperty(PropertyName = "specialRecipe")]
        public int SpecialRecipe { get; set; }

        [JsonProperty(PropertyName = "image")]
        public ImageDto Image { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "tags")]
        public List<string> Tags { get; set; }

        [JsonProperty(PropertyName = "effect")]
        public Dictionary<string, string> Effects { get; set; }

        [JsonProperty(PropertyName = "requiredChampion")]
        public string RequiredChampion { get; set; }

        [JsonProperty(PropertyName = "from")]
        public List<string> From { get; set; }

        [JsonProperty(PropertyName = "group")]
        public string Group { get; set; }

        [JsonProperty(PropertyName = "consumeOnFull")]
        public bool ConsumeOnFull { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "consumed")]
        public bool Consumed { get; set; }

        [JsonProperty(PropertyName = "sanitizedDescription")]
        public string SanitizedDescription { get; set; }

        [JsonProperty(PropertyName = "depth")]
        public int Depth { get; set; }

        [JsonProperty(PropertyName = "stacks")]
        public int Stacks { get; set; }
    }
}
