using Newtonsoft.Json;
using System.Collections.Generic;

namespace League.of.Legends.API.Models
{
    public class Realm
    {
        /// <summary>
        /// Legacy script mode for IE6 or older.
        /// </summary>
        [JsonProperty(PropertyName = "lg")]
        public string Legacy { get; set; }

        /// <summary>
        /// Latest changed version of Dragon Magic.
        /// </summary>
        [JsonProperty(PropertyName = "dd")]
        public string DataDragon { get; set; }

        /// <summary>
        /// Default language for this realm.
        /// </summary>
        [JsonProperty(PropertyName = "l")]
        public string Language { get; set; }

        /// <summary>
        /// Latest changed version for each data type listed.
        /// </summary>
        [JsonProperty(PropertyName = "n")]
        public Dictionary<string, string> LatestChangeVersions { get; set; }

        /// <summary>
        /// Special behavior number identifying the largest profile icon ID that can be
        /// used under 500. Any profile icon that is requested between this number and
        /// 500 should be mapped to 0.
        /// </summary>
        [JsonProperty(PropertyName = "profileiconmax")]
        public int ProfileIconMax { get; set; }

        /// <summary>
        /// Additional API data drawn from other sources that may be related to Data Dragon functionality.
        /// </summary>
        [JsonProperty(PropertyName = "store")]
        public string Store { get; set; }

        /// <summary>
        /// Current version of this file for this realm.
        /// </summary>
        [JsonProperty(PropertyName = "v")]
        public string Version { get; set; }

        /// <summary>
        /// The base CDN URL.
        /// </summary>
        [JsonProperty(PropertyName = "cdn")]
        public string CDN { get; set; }

        /// <summary>
        /// Latest changed version of Dragon Magic's CSS file.
        /// </summary>
        [JsonProperty(PropertyName = "css")]
        public string CSS { get; set; }
    }
}
