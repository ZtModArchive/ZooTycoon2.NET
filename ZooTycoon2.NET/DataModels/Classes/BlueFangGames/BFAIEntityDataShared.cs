using ZooTycoon2.NET.DataModels.Enums;
using ZooTycoon2.NET.DataModels.Interfaces;

namespace ZooTycoon2.NET.DataModels.Classes.BlueFangGames
{
    public class BFAIEntityDataShared : IShared
    {
        public Product Product { get; set; }
        public bool Eyedropper { get; set; }
        public bool SeeThrough { get; set; }
        public bool ValidateDockingPosition { get; set; }
    }
}
