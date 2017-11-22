﻿using RestSharp.Deserializers;

namespace League.API.Models
{
    public class MatchTimelineDto
    {
        [DeserializeAs(Name = "frames")]
        public MatchFrameDtoList Frames { get; set; }

        [DeserializeAs(Name = "frameInterval")]
        public long FrameInterval { get; set; }
    }
}