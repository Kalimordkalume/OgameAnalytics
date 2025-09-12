using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OgameAnalytics.Domain.Buildings;
using OgameAnalytics.Domain.Buildings.Enums;
using OgameAnalytics.Domain.Buildings.Services;
using OgameAnalytics.Domain.Buildings.ValueObjects;
using OgameAnalytics.Domain.Shared.ValueObject;

namespace OgameAnalytics.Domain.Tests.Buildings.Services;
public class BuildingConstructionTimeServiceTest
{
    public BuildingConstructionTimeService _service = new BuildingConstructionTimeService();

    //[Theory]
    //[InlineData(ResourceBuilding.MetalMine,10,4,222)]
    //public void Calculate_ForResourceBuildings_WithoutFactories_ShouldPass(ResourceBuilding buildingId,
    //    int buildingLevel, int universeSpeed, ulong expectedSeconds)

    //{
    //    // We provide a mocked instance of the robotics and nanite factories with level zero.
    //    Building roboticsFactoryMocked = Building.Create(FacilitiesBuilding.RoboticsFactory,BuildingLevel.FromPrimitive(6));
    //    Building naniteFactoryMocked = Building.Create(FacilitiesBuilding.NaniteFactory);

    //    Building buildingToBeTested = Building.Create(buildingId,BuildingLevel.FromPrimitive(buildingLevel));


    //    TimeUnit computedValue = _service.Calculate(buildingToBeTested,roboticsFactoryMocked,naniteFactoryMocked,universeSpeed);

    //    Assert.Equal(expectedSeconds, computedValue.Value);


    //}
}
