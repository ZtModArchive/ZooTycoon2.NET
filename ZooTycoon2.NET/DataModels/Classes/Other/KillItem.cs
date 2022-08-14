using ZooTycoon2.NET.DataModels.Enums;
using ZooTycoon2.NET.DataModels.Interfaces;

namespace ZooTycoon2.NET.DataModels.Classes.Other
{
    public class KillItem : IDetachAction
    {
        public DetachActionDestination Destination { get; set; }
        public KillItem(DetachActionDestination destination)
        {
            Destination = destination;
        }
    }
}
