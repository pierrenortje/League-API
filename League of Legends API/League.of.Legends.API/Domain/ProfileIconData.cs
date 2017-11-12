using RestSharp.Deserializers;

namespace League.of.Legends.API.Domain
{
    public class ProfileIconData
    {
        [DeserializeAs(Name = "data")]
        public ProfileIcon Data { get; set; }

        [DeserializeAs(Name = "type")]
        public string Type { get; set; }

        [DeserializeAs(Name = "version")]
        public string Version { get; set; }
    }

    public class ProfileIcon
    {
        [DeserializeAs(Name = "image")]
        public Image Image { get; set; }

        [DeserializeAs(Name = "id")]
        public long ID { get; set; }
    }
}
