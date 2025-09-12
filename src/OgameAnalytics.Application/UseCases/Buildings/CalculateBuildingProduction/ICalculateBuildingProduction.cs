namespace OgameAnalytics.Application.UseCases.Buildings.CalculateBuildingProduction
{
    public interface ICalculateBuildingProduction
    {

        public CalculateBuildingProductionResponse Handle(CalculateBuildingProductionRequest request);
    }
}
