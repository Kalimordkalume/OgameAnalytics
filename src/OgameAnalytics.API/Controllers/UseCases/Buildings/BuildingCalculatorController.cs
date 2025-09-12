using Microsoft.AspNetCore.Mvc;
using OgameAnalytics.API.Dtos;
using OgameAnalytics.Application.UseCases.Buildings.CalculateBuildingUpgradeCost;

namespace OgameAnalytics.API.Controllers.UseCases.Buildings
{
    [Route("api/use-cases/buildings")]
    [ApiController]
    public class BuildingCalculatorController : ControllerBase
    {
        private readonly ICalculateBuildingUpgradeCost _handler;

        public BuildingCalculatorController(ICalculateBuildingUpgradeCost handler)
        {
            _handler = handler;
        }


        /// <summary>
        /// Calcula el coste de mejora de un edificio en función de su tipo y nivel.
        /// </summary>
        /// <param name="request">Petición que incluye el tipo de edificio y el nivel actual.</param>
        /// <returns>Devuelve el coste de mejora en recursos.</returns>
        [HttpPost("calculate-upgrade-cost")]
        [ProducesResponseType(typeof(CalculateBuildingUpgradeCostResponse), 200)]

        public ActionResult<CalculateBuildingUpgradeCostResponse> CalculateUpgradeCost(
            [FromBody] CalculateBuildingUpgradeCostRequest request)
        {
            if (request is null)
                return BadRequest("La petición no puede ser nula.");

            var resourceCost = _handler.Handle(request);

            var dto = new CalculateBuildingUpgradeCostResponseDto(
                new ResourceCostDto(resourceCost.BuildingUpgradeCost.Metal.Value,
                                    resourceCost.BuildingUpgradeCost.Crystal.Value,
                                    resourceCost.BuildingUpgradeCost.Deuterium.Value,
                                    resourceCost.BuildingUpgradeCost.Energy.Value));

            return Ok(dto);
        }
    }
}
