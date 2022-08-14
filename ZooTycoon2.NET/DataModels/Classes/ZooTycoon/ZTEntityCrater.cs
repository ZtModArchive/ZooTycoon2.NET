using ZooTycoon2.NET.DataModels.Enums;
using ZooTycoon2.NET.DataModels.Interfaces;
using ZooTycoon2.NET.Entities.Objects.Crates;

namespace ZooTycoon2.NET.DataModels.Classes.ZooTycoon
{
    public class ZTEntityCrater : IShared
    {
        public IType CrateType { get; set; } = new Crate();
        public CrateContainer CrateContainer { get; set; } = CrateContainer.Default;
    }
}
