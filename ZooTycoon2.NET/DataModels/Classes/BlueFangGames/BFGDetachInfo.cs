using ZooTycoon2.NET.DataModels.Interfaces;

namespace ZooTycoon2.NET.DataModels.Classes.BlueFangGames
{
    public class BFGDetachInfo : IShared
    {
        public IEnumerable<IDetachInfo>? DetachInfo { get; set; }
    }
}
