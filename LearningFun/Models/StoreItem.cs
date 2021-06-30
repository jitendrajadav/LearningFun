using LearningFun.Enums;

namespace LearningFun.Models
{
    public class StoreItem
    {
        public string Icon { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? Price { get; set; }
        public StoreItemType Type { get; set; }
        public string GroupName { get; set; }
    }
}
