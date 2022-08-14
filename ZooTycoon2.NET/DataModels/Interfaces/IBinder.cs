namespace ZooTycoon2.NET.DataModels.Interfaces
{
    public interface IBinder
    {
        public IEnumerable<IInstance>? Instance { get; set; }
        public IEnumerable<IShared>? Shared { get; set; }
        public IEnumerable<IBinder>? Binder { get; set; }
    }
}
