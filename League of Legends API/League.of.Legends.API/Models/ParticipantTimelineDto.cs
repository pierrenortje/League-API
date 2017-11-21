using RestSharp.Deserializers;
using System.Collections.Generic;

namespace League.of.Legends.API.Models
{
    public class ParticipantTimelineDto
    {
        [DeserializeAs(Name = "lane")]
        public string Lane { get; set; }

        [DeserializeAs(Name = "participantId")]
        public int ParticipantId { get; set; }

        [DeserializeAs(Name = "csDiffPerMinDeltas")]
        public Dictionary<string, double> CsDiffPerMinDeltas { get; set; }

        [DeserializeAs(Name = "goldPerMinDeltas")]
        public Dictionary<string, double> GoldPerMinDeltas { get; set; }

        [DeserializeAs(Name = "xpDiffPerMinDeltas")]
        public Dictionary<string, double> XpDiffPerMinDeltas { get; set; }

        [DeserializeAs(Name = "creepsPerMinDeltas")]
        public Dictionary<string, double> CreepsPerMinDeltas { get; set; }

        [DeserializeAs(Name = "xpPerMinDeltas")]
        public Dictionary<string, double> XpPerMinDeltas { get; set; }

        [DeserializeAs(Name = "role")]
        public string Role { get; set; }

        [DeserializeAs(Name = "damageTakenDiffPerMinDeltas")]
        public Dictionary<string, double> DamageTakenDiffPerMinDeltas { get; set; }

        [DeserializeAs(Name = "damageTakenPerMinDeltas")]
        public Dictionary<string, double> DamageTakenPerMinDeltas { get; set; }
    }
}
