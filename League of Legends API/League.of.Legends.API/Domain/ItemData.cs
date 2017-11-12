using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace League.of.Legends.API.Domain
{
    public class ItemData
    {
        [JsonProperty(PropertyName = "data")]
        public Dictionary<string, Item> Data { get; set; }

        [JsonProperty(PropertyName = "version")]
        public string Version { get; set; }

        [JsonProperty(PropertyName = "tree")]
        public ItemTrees Trees { get; set; }

        [JsonProperty(PropertyName = "groups")]
        public ItemGroups Groups { get; set; }

        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }
    }

    public class Item
    {
        [JsonProperty(PropertyName = "gold")]
        public Gold Gold { get; set; }

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
        public InventoryDataStats Stats { get; set; }

        [JsonProperty(PropertyName = "colloq")]
        public string Colloq { get; set; }

        [JsonProperty(PropertyName = "maps")]
        public Dictionary<string, bool> Maps { get; set; }

        [JsonProperty(PropertyName = "specialRecipe")]
        public int SpecialRecipe { get; set; }

        [JsonProperty(PropertyName = "image")]
        public Image Image { get; set; }

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
        public int stacks { get; set; }
    }

    public class ItemGroup
    {
        [JsonProperty(PropertyName = "MaxGroupOwnable")]
        public string MaxGroupOwnable { get; set; }

        [JsonProperty(PropertyName = "key")]
        public string Key { get; set; }
    }
    public class ItemGroups : List<ItemGroup> { }

    public class ItemTree
    {
        [JsonProperty(PropertyName = "header")]
        public string Header { get; set; }

        [JsonProperty(PropertyName = "tags")]
        public List<string> Tags { get; set; }
    }
    public class ItemTrees : List<ItemTree> { }

    public class Gold
    {
        [JsonProperty(PropertyName = "sell")]
        public int Sell { get; set; }

        [JsonProperty(PropertyName = "total")]
        public int Total { get; set; }

        [JsonProperty(PropertyName = "base")]
        public int Base { get; set; }

        [JsonProperty(PropertyName = "purchasable")]
        public bool Purchasable { get; set; }
    }

    public class InventoryDataStats
    {
        [JsonProperty(PropertyName = "PercentCritDamageMod")]
        public double PercentCritDamageMod { get; set; }

        [JsonProperty(PropertyName = "PercentSpellBlockMod")]
        public double PercentSpellBlockMod { get; set; }

        [JsonProperty(PropertyName = "PercentHPRegenMod")]
        public double PercentHPRegenMod { get; set; }

        [JsonProperty(PropertyName = "PercentMovementSpeedMod")]
        public double PercentMovementSpeedMod { get; set; }

        [JsonProperty(PropertyName = "FlatSpellBlockMod")]
        public double FlatSpellBlockMod { get; set; }

        [JsonProperty(PropertyName = "FlatCritDamageMod")]
        public double FlatCritDamageMod { get; set; }

        [JsonProperty(PropertyName = "FlatEnergyPoolMod")]
        public double FlatEnergyPoolMod { get; set; }

        [JsonProperty(PropertyName = "PercentLifeStealMod")]
        public double PercentLifeStealMod { get; set; }

        [JsonProperty(PropertyName = "FlatMPPoolMod")]
        public double FlatMPPoolMod { get; set; }

        [JsonProperty(PropertyName = "FlatMovementSpeedMod")]
        public double FlatMovementSpeedMod { get; set; }

        [JsonProperty(PropertyName = "PercentAttackSpeedMod")]
        public double PercentAttackSpeedMod { get; set; }

        [JsonProperty(PropertyName = "FlatBlockMod")]
        public double FlatBlockMod { get; set; }

        [JsonProperty(PropertyName = "PercentBlockMod")]
        public double PercentBlockMod { get; set; }

        [JsonProperty(PropertyName = "FlatEnergyRegenMod")]
        public double FlatEnergyRegenMod { get; set; }

        [JsonProperty(PropertyName = "PercentSpellVampMod")]
        public double PercentSpellVampMod { get; set; }

        [JsonProperty(PropertyName = "FlatMPRegenMod")]
        public double FlatMPRegenMod { get; set; }

        [JsonProperty(PropertyName = "PercentDodgeMod")]
        public double PercentDodgeMod { get; set; }

        [JsonProperty(PropertyName = "FlatAttackSpeedMod")]
        public double FlatAttackSpeedMod { get; set; }

        [JsonProperty(PropertyName = "FlatArmorMod")]
        public double FlatArmorMod { get; set; }

        [JsonProperty(PropertyName = "FlatHPRegenMod")]
        public double FlatHPRegenMod { get; set; }

        [JsonProperty(PropertyName = "PercentMagicDamageMod")]
        public double PercentMagicDamageMod { get; set; }

        [JsonProperty(PropertyName = "PercentMPPoolMod")]
        public double PercentMPPoolMod { get; set; }

        [JsonProperty(PropertyName = "FlatMagicDamageMod")]
        public double FlatMagicDamageMod { get; set; }

        [JsonProperty(PropertyName = "PercentMPRegenMod")]
        public double PercentMPRegenMod { get; set; }

        [JsonProperty(PropertyName = "PercentPhysicalDamageMod")]
        public double PercentPhysicalDamageMod { get; set; }

        [JsonProperty(PropertyName = "FlatPhysicalDamageMod")]
        public double FlatPhysicalDamageMod { get; set; }

        [JsonProperty(PropertyName = "PercentHPPoolMod")]
        public double PercentHPPoolMod { get; set; }

        [JsonProperty(PropertyName = "PercentArmorMod")]
        public double PercentArmorMod { get; set; }

        [JsonProperty(PropertyName = "PercentCritChanceMod")]
        public double PercentCritChanceMod { get; set; }

        [JsonProperty(PropertyName = "PercentEXPBonus")]
        public double PercentEXPBonus { get; set; }

        [JsonProperty(PropertyName = "FlatHPPoolMod")]
        public double FlatHPPoolMod { get; set; }

        [JsonProperty(PropertyName = "FlatCritChanceMod")]
        public double FlatCritChanceMod { get; set; }

        [JsonProperty(PropertyName = "FlatEXPBonus")]
        public double FlatEXPBonus { get; set; }
    }
}
