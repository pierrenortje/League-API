using RestSharp.Deserializers;
using System.Collections.Generic;

namespace League.of.Legends.API.Models
{
    public class RuneItem
    {
        [DeserializeAs(Name = "runeId")]
        public int RuneId { get; set; }

        [DeserializeAs(Name = "rank")]
        public int Rank { get; set; }
    }
    public class RuneItemList : List<RuneItem> { }
}
