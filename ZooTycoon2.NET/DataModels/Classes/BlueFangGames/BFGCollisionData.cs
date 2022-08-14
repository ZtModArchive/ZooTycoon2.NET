using ZooTycoon2.NET.DataModels.Enums;
using ZooTycoon2.NET.DataModels.Interfaces;

namespace ZooTycoon2.NET.DataModels.Classes.BlueFangGames
{
    public class BFGCollisionData : IShared
    {
        public float Score { get; set; }
        public IDictionary<TypeScore, float> TypeScores { get; set; } = new Dictionary<TypeScore, float>();
    }
}
