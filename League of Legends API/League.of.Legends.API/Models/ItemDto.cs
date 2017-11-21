using Newtonsoft.Json;
using System.Collections.Generic;

namespace League.of.Legends.API.Models
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
