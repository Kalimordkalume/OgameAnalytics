namespace OgameAnalytics.Application.UseCases.Buildings.CalculateBuildingUpgradeCost
{
    public interface ICalculateBuildingUpgradeCost
    {
        public CalculateBuildingUpgradeCostResponse Handle(CalculateBuildingUpgradeCostRequest request);

    }
}
