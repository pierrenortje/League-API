using Newtonsoft.Json;
using System.Collections.Generic;

namespace League.API.Models
{
    public class MasteryTreeItemDto
    {
        [JsonProperty(PropertyName = "masteryId")]
        public int MasteryId { get; set; }

        [JsonProperty(PropertyName = "prereq")]
        public string Prereq { get; set; }
    }
    public class MasteryTreeItemDtoList : List<MasteryTreeItemDto> { }
}
