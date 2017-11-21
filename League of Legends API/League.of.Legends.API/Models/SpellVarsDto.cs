using Newtonsoft.Json;
using System.Collections.Generic;

namespace League.of.Legends.API.Models
{
    public class SpellVarsDto
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
    public class SpellVarsDtoList : List<SpellVarsDto> { }
}
