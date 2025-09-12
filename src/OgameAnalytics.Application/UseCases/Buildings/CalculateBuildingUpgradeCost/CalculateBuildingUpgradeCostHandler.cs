//namespace OgameAnalytics.Application.UseCases.Buildings.CalculateBuildingUpgradeCost
//{
//public class CalculateBuildingUpgradeCostHandler : ICalculateBuildingUpgradeCost
//{
//    private readonly BuildingCostService _service;

//    public CalculateBuildingUpgradeCostHandler(BuildingCostService service)
//    {
//        _service = service;
//    }



//    public CalculateBuildingUpgradeCostResponse Handle(CalculateBuildingUpgradeCostRequest request)
//    {
//        // Este método tiene que orquestar a todo el dominio para calcular lo necesario.
//        // La información vendrá en el objeto request.
//        var levelFromRequest = new BuildingLevel(request.Level);
//        var buildingTypeFromRequest = request.BuildingType;
//        var baseCost = BuildingCostData.BasicCostOfBuildings[buildingTypeFromRequest];
//        var buildingDefinition = new BuildingDefinition(buildingTypeFromRequest, baseCost);

//        var buildingId = BuildingId.Generate();


//        Building building = Building.Create(buildingDefinition, levelFromRequest);


//        var result = _service.CalculateUpgradeCost(building);


//        return new CalculateBuildingUpgradeCostResponse(result);

//    }
//}
//}

