using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OgameAnalytics.Domain.Exceptions;

namespace OgameAnalytics.Domain.Shared.Exceptions;
public class NotAValidGrowthFactorFormatException : DomainException
{
    private double _metalFactor;
    private double _crystalFactor;
    private double _deuteriumFactor;
    private double _energyFactor;
    private double _populationFactor;
    private double _foodFactor;
    private double _durationFactor;

    public NotAValidGrowthFactorFormatException(
        double metalFactor,
        double crystalFactor,
        double deuteriumFactor,
        double energyFactor,
        double populationFactor,
        double foodFactor,
        double durationFactor) : base(Generate(metalFactor,crystalFactor,deuteriumFactor,energyFactor,populationFactor,foodFactor,durationFactor))
    {
        _metalFactor = metalFactor;
        _crystalFactor = crystalFactor;
        _deuteriumFactor = deuteriumFactor;
        _energyFactor = energyFactor;
        _populationFactor = populationFactor;
        _foodFactor = foodFactor;
        _durationFactor = durationFactor;
    }

    public static string Generate(
        double metalFactor,
        double crystalFactor,
        double deuteriumFactor,
        double energyFactor,
        double populationFactor,
        double foodFactor,
        double durationFactor) {

        return $"The attempted values: [Metal Factor: {metalFactor},Crystal Factor{crystalFactor},Deuterium Factor{deuteriumFactor}," +
            $" Energy Factor{energyFactor}, PopulationFactor{populationFactor}," +
            $"Food Factor: {foodFactor}, Duration Factor: {durationFactor}] are not valid. Ensure the values are greater than 1.";

    }


}
