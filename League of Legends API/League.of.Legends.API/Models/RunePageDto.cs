using RestSharp.Deserializers;
using System.Collections.Generic;

namespace League.of.Legends.API.Models
{
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
}
