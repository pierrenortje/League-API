using RestSharp.Deserializers;

namespace League.API.Models
{
    public class LobbyEventDtoWrapper
    {
        [DeserializeAs(Name = "eventList")]
        public LobbyEventDtoList EventList { get; set; }
    }
}
