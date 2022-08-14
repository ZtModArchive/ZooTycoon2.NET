using ZooTycoon2.NET.DataModels.Classes.BlueFangGames;
using ZooTycoon2.NET.DataModels.Classes.Other;
using ZooTycoon2.NET.DataModels.Classes.ZooTycoon;
using ZooTycoon2.NET.DataModels.Enums;
using ZooTycoon2.NET.DataModels.Interfaces;
using ZooTycoon2.NET.Entities.Objects.Fences;
using ZooTycoon2.NET.Entities.Objects.Misc;

namespace ZooTycoon2.NET.Entities
{
    public abstract class Entity : IType
    {
        public BFTypedBinder BFTypedBinder { get; set; }

        public Entity()
        {
            BFTypedBinder = new BFTypedBinder()
            {
                BinderType = "entity",
                Abstract = true,
                Version = 1,
                VersionReplace = true,
                Instance = new List<IInstance>() { new BFGEntity() },
                Shared = new List<IShared>()
                {
                    new BFGDetachInfo()
                    {
                        DetachInfo = new List<IDetachInfo>()
                        {
                            new DetachActionTable()
                            {
                                Actions = new List<IDetachAction>()
                                {
                                    new DropItem(DetachActionDestination.Drop),
                                    new KillItem(DetachActionDestination.Kill),
                                    new FallItem(DetachActionDestination.Fall)
                                }
                            }
                        }
                    },
                    new ZTEntityCrater(),
                    new ZTEntitySelector()
                    {
                        ParentName = "mainObj",
                        NodeName = "",
                        AnimationTime = (float)0.4,
                        UseFootPrint = true,
                        EntitySelectorProperties = new List<IEntitySelectorProperty>()
                        {
                            new BFPhysObj()
                            {
                                AllowHighlight = false
                            }
                        }
                    },
                    new ZTPlacementData()
                    {
                        Moveable = true,
                        Rotatable = true,
                        StompData = new Dictionary<StompDataFilter, StompData>()
                        {
                            {
                                StompDataFilter.Allow,
                                new StompData()
                                {
                                    StompTypes = new List<Type>()
                                    {
                                        typeof(Path),
                                        typeof(TankwallSupport),
                                        typeof(TankLadder),
                                        typeof(FossilSite)
                                    }
                                }
                            },
                            {
                                StompDataFilter.Prevent,
                                new StompData()
                            }
                        }
                    },
                    new BFAIEntityDataShared()
                    {
                        Product = Product.Zoo2,
                        Eyedropper = true,
                        SeeThrough = true,
                        ValidateDockingPosition = true
                    }
                },
                Binder = new List<IBinder>()
                {
                    new BFBinder()
                    {
                        Required = true,
                        Instance = new List<IInstance>()
                        {
                            new BFGEntitySndComponent()
                        }
                    },
                    new BFBinder()
                    {
                        Required = true,
                        Instance = new List<IInstance>()
                        {
                            new BFGEntityContainer()
                            {
                                Slots = new List<ISlot>()
                                {
                                    new BFGEntityContainerSlot()
                                }
                            }
                        }
                    }
                }
            };
        }
    }
}
