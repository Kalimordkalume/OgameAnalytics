using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OgameAnalytics.Domain.Exceptions;

namespace OgameAnalytics.Domain.Buildings.Exceptions;
public sealed class UnknownBuildingTypeException : DomainException
{

    public Enum AttemptedBuildingEnum;

    public UnknownBuildingTypeException(Enum buildingType) : base(Generate(buildingType))
    {
        AttemptedBuildingEnum = buildingType;

    }

    private static string Generate(Enum buildingType)
    {
        return $"Your attempted building type: [{buildingType}] does not exist. Please, try one that exist.";
    }
}
