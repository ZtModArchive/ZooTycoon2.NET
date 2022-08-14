using ZooTycoon2.NET.DataModels.Enums;

namespace ZooTycoon2.NET.DataModels.Interfaces
{
    public interface IDetachAction
    {
        public DetachActionDestination Destination { get; set; }
    }
}
