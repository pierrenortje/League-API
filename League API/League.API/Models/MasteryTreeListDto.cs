using Newtonsoft.Json;

namespace League.API.Models
{
    public class MasteryTreeListDto
    {
        [JsonProperty(PropertyName = "masteryTreeItems")]
        public MasteryTreeItemDtoList MasteryTreeItems { get; set; }
    }
}
