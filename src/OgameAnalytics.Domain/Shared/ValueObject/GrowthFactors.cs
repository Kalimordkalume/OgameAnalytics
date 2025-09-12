using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OgameAnalytics.Domain.Shared.Exceptions;

namespace OgameAnalytics.Domain.Shared.ValueObject;
public record GrowthFactors
{
    public double MetalFactor { get; set; }
    public double CrystalFactor { get; set; }

    public double DeuteriumFactor { get; set; }

    public double EnergyFactor { get; set; }

    public double PopulationFactor { get; set; }

    public double FoodFactor { get; set; }

    public double DurationFactor { get; set; }

    private GrowthFactors(double metalFactor, double crystalFactor, double deuteriumFactor, double energyFactor, double populationFactor, double foodFactor, double durationFactor)
    {
        MetalFactor = metalFactor;
        CrystalFactor = crystalFactor;
        DeuteriumFactor = deuteriumFactor;
        EnergyFactor = energyFactor;
        PopulationFactor = populationFactor;
        FoodFactor = foodFactor;
        DurationFactor = durationFactor;
    }

    public static GrowthFactors FromPrimitives(double metalFactor, double crystalFactor, double deuteriumFactor, double energyFactor, double populationFactor, double foodFactor, double durationFactor)
    {
        if ((metalFactor < 1) || (crystalFactor < 1) || (deuteriumFactor < 1) || (energyFactor < 1) || (populationFactor < 1) || (foodFactor < 1) || (durationFactor < 1)
                || (foodFactor < 1)) throw new NotAValidGrowthFactorFormatException(metalFactor,crystalFactor,deuteriumFactor,energyFactor,populationFactor,foodFactor,durationFactor);
        return new GrowthFactors(metalFactor, crystalFactor, deuteriumFactor, energyFactor, populationFactor, foodFactor, durationFactor);
    }
}
