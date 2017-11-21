using RestSharp.Deserializers;
using System.Collections.Generic;

namespace League.of.Legends.API.Models
{
    public class GameCustomizationObject
    {
        /// <summary>
        /// Category identifier for Game Customization.
        /// </summary>
        [DeserializeAs(Name = "category")]
        public string Category { get; set; }

        /// <summary>
        /// Game Customization content.
        /// </summary>
        [DeserializeAs(Name = "content")]
        public string Content { get; set; }
    }
    public class GameCustomizationObjects : List<GameCustomizationObject> { }
}
