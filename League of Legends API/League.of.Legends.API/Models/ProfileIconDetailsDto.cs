using RestSharp.Deserializers;

namespace League.of.Legends.API.Models
{
    public class ProfileIconDetailsDto
    {
        [DeserializeAs(Name = "image")]
        public ImageDto Image { get; set; }

        [DeserializeAs(Name = "id")]
        public long ID { get; set; }
    }
}
