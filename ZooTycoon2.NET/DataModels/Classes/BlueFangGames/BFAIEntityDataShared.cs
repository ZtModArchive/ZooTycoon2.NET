using ZooTycoon2.NET.DataModels.Enums;
using ZooTycoon2.NET.DataModels.Interfaces;

namespace ZooTycoon2.NET.DataModels.Classes.BlueFangGames
{
    public class BFAIEntityDataShared : IShared
    {
        public Product? Product { get; set; }
        public bool? Eyedropper { get; set; }
        public bool? SeeThrough { get; set; }
        public bool? ValidateDockingPosition { get; set; }
        public bool? ReceiveUpdates { get; set; }
        public bool? VisibleThroughRemoteStations { get; set; }
        public bool? CommerceBuilding { get; set; }
        public bool? DonationAcceptor { get; set; }
        public GenerateName? GenerateName { get; set; }
        public float? FameReq { get; set; }
        public float? BuildingStrength { get; set; }

        public BFAIEntityDataShared SetProduct (Product product)
        {
            Product = product;
            return this;
        }
        public BFAIEntityDataShared SetEyedropper(bool eyedropper)
        {
            Eyedropper = eyedropper;
            return this;
        }
        public BFAIEntityDataShared SetSeeThrough(bool seeThrough)
        {
            SeeThrough = SeeThrough;
            return this;
        }
        public BFAIEntityDataShared SetValidateDockingPosition(bool validateDockingPosition)
        {
            ValidateDockingPosition = validateDockingPosition;
            return this;
        }
        public BFAIEntityDataShared SetReceiveUpdates(bool receiveUpdates)
        {
            ReceiveUpdates = receiveUpdates;
            return this;
        }
        public BFAIEntityDataShared SetVisibleThroughRemoteStations(bool visibleThroughRemoteStations)
        {
            VisibleThroughRemoteStations = visibleThroughRemoteStations;
            return this;
        }
        public BFAIEntityDataShared SetCommerceBuilding(bool commerceBuilding)
        {
            CommerceBuilding = commerceBuilding;
            return this;
        }
        public BFAIEntityDataShared SetDonationAcceptor(bool donationAcceptor)
        {
            DonationAcceptor = donationAcceptor;
            return this;
        }
        public BFAIEntityDataShared SetGenerateName(GenerateName generateName)
        {
            GenerateName = GenerateName;
            return this;
        }
        public BFAIEntityDataShared SetFameReq(float fameReq)
        {
            FameReq = fameReq;
            return this;
        }
        public BFAIEntityDataShared SetBuildingStrength(float buildingStrength)
        {
            BuildingStrength = buildingStrength;
            return this;
        }
    }
}
