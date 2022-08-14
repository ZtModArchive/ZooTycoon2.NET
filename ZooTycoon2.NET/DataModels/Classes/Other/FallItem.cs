using ZooTycoon2.NET.DataModels.Enums;
using ZooTycoon2.NET.DataModels.Interfaces;

namespace ZooTycoon2.NET.DataModels.Classes.Other
{
    public class FallItem : IDetachAction
    {
        public DetachActionDestination Destination { get; set; }
    }
}
