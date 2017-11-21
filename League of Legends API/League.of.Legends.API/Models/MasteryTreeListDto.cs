using Newtonsoft.Json;

namespace League.of.Legends.API.Models
{
    public class MasteryTreeListDto
    {
        [JsonProperty(PropertyName = "masteryTreeItems")]
        public MasteryTreeItemDtoList MasteryTreeItems { get; set; }
    }
}
