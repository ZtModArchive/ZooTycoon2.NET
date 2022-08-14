using ZooTycoon2.NET.DataModels.Interfaces;

namespace ZooTycoon2.NET.DataModels.Classes.BlueFangGames
{
    public class BFTypedBinder : IBinder
    {
        public string? BinderType { get; set; }
        public bool Abstract { get; set; }
        public int Version { get; set; }
        public bool VersionReplace { get; set; }
        public IType? ParentType { get; set; }
        public IEnumerable<IInstance>? Instance { get; set; }
        public IEnumerable<IShared>? Shared { get; set; }
        public IEnumerable<IBinder>? Binder { get; set; }
    }
}
