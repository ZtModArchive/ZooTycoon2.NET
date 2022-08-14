using ZooTycoon2.NET.DataModels.Interfaces;

namespace ZooTycoon2.NET.DataModels.Classes.ZooTycoon
{
    public class ZTEntityCrater : IShared
    {
        public IType CrateType { get; set; }
        public string CrateContainer { get; set; } = "default";
        public ZTEntityCrater(IType crateType)
        {
            CrateType = crateType;
        }

        public ZTEntityCrater(IType crateType, string crateContainer)
        {
            CrateType = crateType;
            CrateContainer = crateContainer;
        }
    }
}
