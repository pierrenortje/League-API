using RestSharp.Deserializers;

namespace League.of.Legends.API.Models
{
    public class Observer
    {
        /// <summary>
        /// Key used to decrypt the spectator grid game data for playback.
        /// </summary>
        [DeserializeAs(Name = "encryptionKey")]
        public string EncryptionKey { get; set; }
    }
}
