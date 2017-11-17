using Newtonsoft.Json;
using System.Collections.Generic;

namespace League.of.Legends.API.Models
{
    public class ChampionDetailsData
    {
        [JsonProperty(PropertyName = "keys")]
        public Dictionary<string, string> Keys { get; set; }

        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        [JsonProperty(PropertyName = "version")]
        public string Version { get; set; }

        [JsonProperty(PropertyName = "data")]
        public Dictionary<string, ChampionDetails> Data { get; set; }

        [JsonProperty(PropertyName = "format")]
        public string Format { get; set; }
    }

    public class ChampionDetails
    {
        [JsonProperty(PropertyName = "info")]
        public ChampionInfo Info { get; set; }

        [JsonProperty(PropertyName = "enemytips")]
        public List<string> EnemyTips { get; set; }

        [JsonProperty(PropertyName = "stats")]
        public ChampionStats Stats { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        [JsonProperty(PropertyName = "image")]
        public Image Image { get; set; }

        [JsonProperty(PropertyName = "tags")]
        public List<string> Tags { get; set; }

        [JsonProperty(PropertyName = "partype")]
        public string ParType { get; set; }

        [JsonProperty(PropertyName = "skins")]
        public ChampionSkins Skins { get; set; }

        [JsonProperty(PropertyName = "passive")]
        public ChampionPassive Passive { get; set; }

        [JsonProperty(PropertyName = "recommended")]
        public ChampionRecommendedList RecommendedList { get; set; }

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

    public class ChampionInfo
    {
        [JsonProperty(PropertyName = "difficulty")]
        public int Difficulty { get; set; }

        [JsonProperty(PropertyName = "attack")]
        public int Attack { get; set; }

        [JsonProperty(PropertyName = "defense")]
        public int Defense { get; set; }

        [JsonProperty(PropertyName = "magic")]
        public int Magic { get; set; }
    }

    public class ChampionStats
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

    public class Image
    {
        [JsonProperty(PropertyName = "full")]
        public string Full { get; set; }

        [JsonProperty(PropertyName = "group")]
        public string Group { get; set; }

        [JsonProperty(PropertyName = "sprite")]
        public string Sprite { get; set; }

        [JsonProperty(PropertyName = "h")]
        public int H { get; set; }

        [JsonProperty(PropertyName = "w")]
        public int W { get; set; }

        [JsonProperty(PropertyName = "y")]
        public int Y { get; set; }

        [JsonProperty(PropertyName = "x")]
        public int X { get; set; }
    }
    public class Images : List<Image> { }

    public class ChampionSkin
    {
        [JsonProperty(PropertyName = "num")]
        public string Num { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "id")]
        public string ID { get; set; }
    }
    public class ChampionSkins : List<ChampionSkin> { }

    public class ChampionPassive
    {
        [JsonProperty(PropertyName = "image")]
        public Image Image { get; set; }

        [JsonProperty(PropertyName = "sanitizedDescription")]
        public string SanitizedDescription { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
    }

    public class ChampionRecommended
    {
        [JsonProperty(PropertyName = "map")]
        public string Map { get; set; }

        [JsonProperty(PropertyName = "blocks")]
        public ChampionBlocks Blocks { get; set; }

        [JsonProperty(PropertyName = "champion")]
        public string Champion { get; set; }

        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        [JsonProperty(PropertyName = "priority")]
        public bool Priority { get; set; }

        [JsonProperty(PropertyName = "mode")]
        public string Mode { get; set; }

        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }
    }
    public class ChampionRecommendedList : List<ChampionRecommended> { }

    public class ChampionSpell
    {
        [JsonProperty(PropertyName = "cooldownBurn")]
        public string CooldownBurn { get; set; }

        [JsonProperty(PropertyName = "resource")]
        public string Resource { get; set; }

        [JsonProperty(PropertyName = "leveltip")]
        public LevelTip Leveltip { get; set; }

        [JsonProperty(PropertyName = "vars")]
        public ChampionSpellVars Vars { get; set; }

        [JsonProperty(PropertyName = "costType")]
        public string CostType { get; set; }

        [JsonProperty(PropertyName = "image")]
        public Image Image { get; set; }

        [JsonProperty(PropertyName = "sanitizedDescription")]
        public string SanitizedDescription { get; set; }

        [JsonProperty(PropertyName = "sanitizedTooltip")]
        public string SanitizedTooltip { get; set; }

        [JsonProperty(PropertyName = "effect")]
        public List<double> Effect { get; set; }

        [JsonProperty(PropertyName = "tooltip")]
        public string Tooltip { get; set; }

        [JsonProperty(PropertyName = "maxrank")]
        public int Maxrank { get; set; }

        [JsonProperty(PropertyName = "costBurn")]
        public string CostBurn { get; set; }

        [JsonProperty(PropertyName = "rangeBurn")]
        public string RangeBurn { get; set; }

        [JsonProperty(PropertyName = "range")]
        public object Range { get; set; }

        [JsonProperty(PropertyName = "cooldown")]
        public List<double> Cooldown { get; set; }

        [JsonProperty(PropertyName = "cost")]
        public List<int> Cost { get; set; }

        [JsonProperty(PropertyName = "key")]
        public string Key { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "effectBurn")]
        public List<string> EffectBurn { get; set; }

        [JsonProperty(PropertyName = "altimages")]
        public Images Altimages { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
    }
    public class ChampionSpells : List<ChampionSpell> { }

    public class ChampionBlock
    {
        [JsonProperty(PropertyName = "items")]
        public ChampionBlockItems Items { get; set; }

        [JsonProperty(PropertyName = "recMath")]
        public bool RecMath { get; set; }

        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }
    }
    public class ChampionBlocks : List<ChampionBlock> { }

    public class ChampionBlockItem
    {
        [JsonProperty(PropertyName = "count")]
        public int Count { get; set; }

        [JsonProperty(PropertyName = "id")]
        public int ID { get; set; }
    }
    public class ChampionBlockItems : List<ChampionBlockItem> { }

    public class LevelTip
    {
        [JsonProperty(PropertyName = "effect")]
        public List<string> Effect { get; set; }

        [JsonProperty(PropertyName = "label")]
        public List<string> Label { get; set; }
    }

    public class ChampionSpellVar
    {
        [JsonProperty(PropertyName = "ranksWith")]
        public string RanksWith { get; set; }

        [JsonProperty(PropertyName = "dyn")]
        public string Dyn { get; set; }

        [JsonProperty(PropertyName = "link")]
        public string Link { get; set; }

        [JsonProperty(PropertyName = "coeff")]
        public List<double> Coeff { get; set; }

        [JsonProperty(PropertyName = "key")]
        public string Key { get; set; }
    }
    public class ChampionSpellVars : List<ChampionSpellVar> { }
}
