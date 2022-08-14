using ZooTycoon2.NET.DataModels.Interfaces;

namespace ZooTycoon2.NET.DataModels.Classes.BlueFangGames
{
    public class BFGEntityContainer : IInstance
    {
        public IEnumerable<ISlot> Slots { get; set; } = Enumerable.Empty<ISlot>();
    }
}
