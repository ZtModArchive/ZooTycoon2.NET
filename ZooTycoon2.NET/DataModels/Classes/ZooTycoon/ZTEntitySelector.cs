using ZooTycoon2.NET.DataModels.Interfaces;

namespace ZooTycoon2.NET.DataModels.Classes.ZooTycoon
{
    public class ZTEntitySelector : IShared
    {
        public string ParentName { get; set; } = string.Empty;
        public string NodeName { get; set; } = string.Empty;
        public float AnimationTime { get; set; }
        public bool UseFootPrint { get; set; }
        public IEnumerable<IEntitySelectorProperty> EntitySelectorProperties { get; set; } = Enumerable.Empty<IEntitySelectorProperty>();
    }
}
