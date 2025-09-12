namespace OgameAnalytics.Domain.Shared.ValueObject;
public record EconomicUnit
{
    public ulong MetalValue { get; private set; }
    public ulong CrystalValue { get; private set; }
    public ulong DeuteriumValue { get; private set; }
    public ulong EnergyValue { get; private set; }

    public ulong PopulationValue { get; private set; }

    public ulong FoodValue { get; private set; }

    private EconomicUnit(ulong metalValue, ulong crystalValue, ulong deuteriumValue, ulong energyValue, ulong populationValue, ulong foodValue)
    {
        MetalValue = metalValue;
        CrystalValue = crystalValue;
        DeuteriumValue = deuteriumValue;
        EnergyValue = energyValue;
        PopulationValue = populationValue;
        FoodValue = foodValue;
    }

    public static EconomicUnit CreateNewMineralUnit(ulong metalValue, ulong crystalValue, ulong deuteriumValue)
    {
        return new(metalValue, crystalValue, deuteriumValue, 0, 0, 0);

    }

    public static EconomicUnit CreateNewEnergyUnit(ulong energyValue)
    {
        return new(0, 0, 0, energyValue, 0, 0);
    }

    public static EconomicUnit CreateLifeFormUnit(ulong populationValue, ulong foodValue)
    {
        return new(0, 0, 0, 0, populationValue, foodValue);
    }

    public static EconomicUnit FromPrimitives(ulong metalValue, ulong crystalValue, ulong deuteriumValue, ulong energyValue, ulong populationValue, ulong foodValue)
    {
        return new(metalValue, crystalValue, deuteriumValue, energyValue, populationValue, foodValue);
    }

    //public static EconomicUnit operator *(EconomicUnit unit, ulong factor)
    //{
    //    return new(unit.MetalValue * factor, unit.CrystalValue * factor, unit.DeuteriumValue * factor, unit.EnergyValue * factor, unit.PopulationValue * factor, unit.FoodValue * factor);
        
    //}

    //public static EconomicUnit operator *(ulong factor, EconomicUnit unit)
    //{
    //    return new(unit.MetalValue * factor, unit.CrystalValue * factor, unit.DeuteriumValue * factor, unit.EnergyValue * factor, unit.PopulationValue * factor, unit.FoodValue * factor);

    //}
}
