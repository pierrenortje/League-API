using RestSharp.Deserializers;

namespace League.API.Models
{
    public class MiniSeriesDto
    {
        [DeserializeAs(Name = "wins")]
        public int Wins { get; set; }

        [DeserializeAs(Name = "losses")]
        public int Losses { get; set; }

        [DeserializeAs(Name = "target")]
        public int Target { get; set; }

        [DeserializeAs(Name = "progress")]
        public string Progress { get; set; }
    }
}
