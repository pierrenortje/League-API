#region License
// Copyright (c) 2017 Pierre Nortje
//
// Permission is hereby granted, free of charge, to any person
// obtaining a copy of this software and associated documentation
// files (the "Software"), to deal in the Software without
// restriction, including without limitation the rights to use,
// copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the
// Software is furnished to do so, subject to the following
// conditions:
//
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
#endregion

using Newtonsoft.Json;
using System.Collections.Generic;

namespace League.API.Models
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
