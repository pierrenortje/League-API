using RestSharp.Deserializers;
using System.Collections.Generic;

namespace League.API.Models
{
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
