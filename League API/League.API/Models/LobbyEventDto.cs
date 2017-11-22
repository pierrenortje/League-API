using RestSharp.Deserializers;
using System.Collections.Generic;

namespace League.API.Models
{
    public class LobbyEventDto
    {
        /// <summary>
        /// The type of event that was triggered.
        /// </summary>
        [DeserializeAs(Name = "eventType")]
        public string EventType { get; set; }

        /// <summary>
        /// The summoner that triggered the event.
        /// </summary>
        [DeserializeAs(Name = "summonerId")]
        public string SummonerId { get; set; }

        /// <summary>
        /// Timestamp from the event.
        /// </summary>
        [DeserializeAs(Name = "timestamp")]
        public string Timestamp { get; set; }
    }
    public class LobbyEventDtoList : List<LobbyEventDto> { }
}
