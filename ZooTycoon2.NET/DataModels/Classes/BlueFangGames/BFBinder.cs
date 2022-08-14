using ZooTycoon2.NET.DataModels.Interfaces;

namespace ZooTycoon2.NET.DataModels.Classes.BlueFangGames
{
    public class BFBinder : IBinder
    {
        public bool? Required { get; set; }
        public IEnumerable<IInstance>? Instance { get; set; }
        public IEnumerable<IShared>? Shared { get; set; }
        public IEnumerable<IBinder>? Binder { get; set; }
    }
}
