using ZooTycoon2.NET.DataModels.Interfaces;

namespace ZooTycoon2.NET.DataModels.Classes.Other
{
    public class DetachActionTable : IDetachInfo
    {
        public IEnumerable<IDetachAction>? Actions { get; set; }
    }
}
