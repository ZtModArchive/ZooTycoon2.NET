using ZooTycoon2.NET.DataModels.Classes.BlueFangGames;
using ZooTycoon2.NET.DataModels.Interfaces;

namespace ZooTycoon2.NET.Entities
{
    public abstract class Entity : IType
    {
        public BFTypedBinder BFTypedBinder { get; set; }

        public Entity(string binderType)
        {
            BFTypedBinder = new BFTypedBinder(binderType);
        }
    }
}
