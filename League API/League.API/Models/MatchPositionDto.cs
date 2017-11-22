using RestSharp.Deserializers;

namespace League.API.Models
{
    public class MatchPositionDto
    {
        [DeserializeAs(Name = "y")]
        public int Y { get; set; }

        [DeserializeAs(Name = "x")]
        public int X { get; set; }
    }
}
