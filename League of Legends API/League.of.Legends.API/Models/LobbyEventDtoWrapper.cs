using RestSharp.Deserializers;

namespace League.of.Legends.API.Models
{
    public class LobbyEventDtoWrapper
    {
        [DeserializeAs(Name = "eventList")]
        public LobbyEventDtoList EventList { get; set; }
    }
}
