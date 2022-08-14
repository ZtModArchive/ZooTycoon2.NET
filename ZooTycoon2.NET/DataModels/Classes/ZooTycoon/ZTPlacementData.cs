using ZooTycoon2.NET.DataModels.Classes.Other;
using ZooTycoon2.NET.DataModels.Enums;
using ZooTycoon2.NET.DataModels.Interfaces;

namespace ZooTycoon2.NET.DataModels.Classes.ZooTycoon
{
    public class ZTPlacementData : IShared
    {
        public bool Moveable { get; set; }
        public bool Rotatable { get; set; }
        public IDictionary<StompDataFilter, StompData> StompData = new Dictionary<StompDataFilter, StompData>();
    }
}
