using Newtonsoft.Json;
using System.Collections.Generic;

namespace League.of.Legends.API.Models
{
    public class MasteryData
    {
        [JsonProperty(PropertyName = "data")]
        public Dictionary<string, Item> Data { get; set; }

        [JsonProperty(PropertyName = "version")]
        public string Version { get; set; }

        [JsonProperty(PropertyName = "tree")]
        public ItemTrees Trees { get; set; }

        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }
    }

    public class Mastery
    {
        [JsonProperty(PropertyName = "prereq")]
        public string Prereq { get; set; }

        [JsonProperty(PropertyName = "masteryTree")]
        public string MasteryTree { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "ranks")]
        public int Ranks { get; set; }

        [JsonProperty(PropertyName = "image")]
        public Image Image { get; set; }

        [JsonProperty(PropertyName = "sanitizedDescription")]
        public List<string> SanitizedDescription { get; set; }

        [JsonProperty(PropertyName = "id")]
        public int ID { get; set; }

        [JsonProperty(PropertyName = "description")]
        public List<string> description { get; set; }
    }

    public class MasteryTreeList
    {
        [JsonProperty(PropertyName = "masteryTreeItems")]
        public MasteryTreeItems MasteryTreeItems { get; set; }
    }

    public class MasteryTreeItem
    {
        [JsonProperty(PropertyName = "masteryId")]
        public int MasteryId { get; set; }

        [JsonProperty(PropertyName = "prereq")]
        public string Prereq { get; set; }
    }
    public class MasteryTreeItems : List<MasteryTreeItem> { }
}
