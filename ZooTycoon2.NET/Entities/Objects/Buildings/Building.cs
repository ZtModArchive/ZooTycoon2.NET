using ZooTycoon2.NET.DataModels.Classes.BlueFangGames;
using ZooTycoon2.NET.DataModels.Classes.Other;
using ZooTycoon2.NET.DataModels.Classes.ZooTycoon;
using ZooTycoon2.NET.DataModels.Enums;
using ZooTycoon2.NET.Entities.Objects.Enrichments;
using ZooTycoon2.NET.Entities.Objects.Foliages;
using ZooTycoon2.NET.Entities.Objects.Items;

namespace ZooTycoon2.NET.Entities.Objects.Buildings
{
    public abstract class Building : Entity
    {
        public Building() : base()
        {
            BFTypedBinder.BinderType = "building";

            if (BFTypedBinder.Shared == null) throw new ArgumentNullException();

            BFAIEntityDataShared bFAIEntityDataShared = (BFAIEntityDataShared)BFTypedBinder.Shared.Where(s => s.GetType() == typeof(BFAIEntityDataShared)).First();
            bFAIEntityDataShared
                .SetVisibleThroughRemoteStations(true)
                .SetCommerceBuilding(false)
                .SetDonationAcceptor(false)
                .SetReceiveUpdates(true)
                .SetSeeThrough(false)
                .SetGenerateName(GenerateName.ByType)
                .SetFameReq(0)
                .SetBuildingStrength(100)
                ;

            ZTPlacementData zTPlacementData = (ZTPlacementData)BFTypedBinder.Shared.Where(s => s.GetType() == typeof(ZTPlacementData)).First();
            zTPlacementData
                .SetMoveable(false)
                .SetRandomRotate(false)
                .SetGridSnap(true)
                .SetAutoFootprint(true)
                .SetTerrainFlatten(true)
                .SetSound("place_building")
                .SetDeleteSound("recycle_building")
                .SetMinimumHeadroom((float)5.0)
                ;
            if (!zTPlacementData.StompData.ContainsKey(StompDataFilter.Delete))
                zTPlacementData.StompData.Add(StompDataFilter.Delete, new StompData());
            IEnumerable<Type> stompTypes = zTPlacementData.StompData[StompDataFilter.Delete].StompTypes
                .Append(typeof(Treat))
                .Append(typeof(Bush))
                .Append(typeof(Grass))
                .Append(typeof(Wildflowers))
                .Append(typeof(Fungi))
                .Append(typeof(WatersurfaceFoliage))
                .Append(typeof(Poop))
                ;
            stompTypes = stompTypes.Distinct();
        }
    }
}
