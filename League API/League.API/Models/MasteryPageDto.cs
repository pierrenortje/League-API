using RestSharp.Deserializers;
using System.Collections.Generic;

namespace League.API.Models
{
    public class MasteryPageDto
    {
        /// <summary>
        /// Indicates if the mastery page is the current mastery page.
        /// </summary>
        [DeserializeAs(Name = "current")]
        public bool Current { get; set; }

        /// <summary>
        /// Collection of masteries associated with the mastery page.
        /// </summary>
        [DeserializeAs(Name = "masteries")]
        public Masteries Masteries { get; set; }

        /// <summary>
        /// Mastery page name.
        /// </summary>
        [DeserializeAs(Name = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Mastery page ID.
        /// </summary>
        [DeserializeAs(Name = "id")]
        public long ID { get; set; }
    }
    public class MasteryPageDtoList : List<MasteryPageDto> { }
}
