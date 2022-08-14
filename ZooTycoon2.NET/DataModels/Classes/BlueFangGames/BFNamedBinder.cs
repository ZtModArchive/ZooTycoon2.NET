using ZooTycoon2.NET.DataModels.Interfaces;

namespace ZooTycoon2.NET.DataModels.Classes.BlueFangGames
{
    internal class BFNamedBinder : IBinder
    {
        public string BinderName { get; set; } = string.Empty;
        public IEnumerable<IInstance>? Instance { get; set; }
        public IEnumerable<IShared>? Shared { get; set; }
        public IEnumerable<IBinder>? Binder { get; set; }
    }
}
