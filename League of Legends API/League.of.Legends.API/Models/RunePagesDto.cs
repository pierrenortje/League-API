using RestSharp.Deserializers;
using System.Collections.Generic;

namespace League.of.Legends.API.Models
{
    public class RunePagesDto
    {
        /// <summary>
        /// Collection of rune pages associated with the summoner.
        /// </summary>
        [DeserializeAs(Name = "pages")]
        public RunePageDtoList Pages { get; set; }

        /// <summary>
        /// Summoner ID.
        /// </summary>
        [DeserializeAs(Name = "summonerId")]
        public long SummonerId { get; set; }
    }

    public class RunePageDto
    {
        /// <summary>
        /// Indicates if the page is the current page.
        /// </summary>
        [DeserializeAs(Name = "current")]
        public bool Current { get; set; }

        /// <summary>
        /// Collection of rune slots associated with the rune page.
        /// </summary>
        [DeserializeAs(Name = "slots")]
        public RuneSlotDtoList Slots { get; set; }

        /// <summary>
        /// Rune page name.
        /// </summary>
        [DeserializeAs(Name = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Rune page ID.
        /// </summary>
        [DeserializeAs(Name = "id")]
        public long ID { get; set; }
    }
    public class RunePageDtoList : List<RunePageDto> { }

    public class RuneSlotDto
    {
        /// <summary>
        /// Rune slot ID.
        /// </summary>
        [DeserializeAs(Name = "runeSlotId")]
        public int RuneSlotId { get; set; }

        /// <summary>
        /// Rune ID associated with the rune slot.
        /// For static information correlating to rune IDs, please refer to the LoL Static Data API.
        /// </summary>
        [DeserializeAs(Name = "runeId")]
        public int RuneId { get; set; }
    }
    public class RuneSlotDtoList : List<RuneSlotDto> { }
}
