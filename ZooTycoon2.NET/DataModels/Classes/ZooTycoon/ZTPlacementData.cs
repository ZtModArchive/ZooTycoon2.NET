using ZooTycoon2.NET.DataModels.Classes.Other;
using ZooTycoon2.NET.DataModels.Enums;
using ZooTycoon2.NET.DataModels.Interfaces;

namespace ZooTycoon2.NET.DataModels.Classes.ZooTycoon
{
    public class ZTPlacementData : IShared
    {
        public bool Moveable { get; set; }
        public bool Rotatable { get; set; }
        public bool RandomRotate { get; set; }
        public bool GridSnap { get; set; }
        public bool AutoFootprint { get; set; }
        public bool TerrainFlatten { get; set; }
        public string Sound { get; set; } = string.Empty;
        public string DeleteSound { get; set; } =  string.Empty;
        public float MinimumHeadroom { get; set; }
        public IDictionary<StompDataFilter, StompData> StompData = new Dictionary<StompDataFilter, StompData>();

        public ZTPlacementData SetMoveable(bool moveable)
        {
            Moveable = moveable;
            return this;
        }
        public ZTPlacementData SetRotatable(bool rotatable)
        {
            Rotatable = rotatable;
            return this;
        }
        public ZTPlacementData SetRandomRotate(bool randomRotate)
        {
            RandomRotate = randomRotate;
            return this;
        }
        public ZTPlacementData SetGridSnap(bool gridSnap)
        {
            GridSnap = gridSnap;
            return this;
        }
        public ZTPlacementData SetAutoFootprint(bool autoFootprint)
        {
            AutoFootprint = autoFootprint;
            return this;
        }
        public ZTPlacementData SetTerrainFlatten(bool terrainFlatten)
        {
            TerrainFlatten = terrainFlatten;
            return this;
        }
        public ZTPlacementData SetSound(string sound)
        {
            Sound = sound;
            return this;
        }
        public ZTPlacementData SetDeleteSound(string deleteSound)
        {
            DeleteSound = deleteSound;
            return this;
        }
        public ZTPlacementData SetMinimumHeadroom(float minimumHeadroom)
        {
            MinimumHeadroom = minimumHeadroom;
            return this;
        }
        public ZTPlacementData SetStompData(IDictionary<StompDataFilter, StompData> stompdata)
        {
            StompData = stompdata;
            return this;
        }
    }
}
