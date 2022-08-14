using ZooTycoon2.NET.DataModels.Enums;
using ZooTycoon2.NET.DataModels.Interfaces;

namespace ZooTycoon2.NET.DataModels.Classes.ZooTycoon
{
    public class ZTPlacementData : IShared
    {
        public bool Moveable { get; set; }
        public bool Rotatable { get; set; }
        public Dictionary<StompDataFilter,IEnumerable<IType>> StompData { get; set; } = new Dictionary<StompDataFilter,IEnumerable<IType>>();
    }
}
