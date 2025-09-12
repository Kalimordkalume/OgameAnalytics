namespace OgameAnalytics.Domain.Tests.Buildings.TestData;
public class BasicMinesProduction
{
    public static Dictionary<int, ulong> ProductionValuesForMetalMine = new()
    {
        {0, 0},
        { 1,33},
        { 2,72},
        { 3,119},
        { 4,175},
        { 5,241},
        { 40,54_311}
    };

    public static Dictionary<int, ulong> ProductionValuesForCrystalMine = new()
    {
        { 0,0},
        { 1,22},
        { 2,48},
        { 3,79},
        { 4,117},
        { 5,161},
        { 40,36_207}

    };

    public static Dictionary<int, ulong> ProductionValuesForDeuteriumMine = new()
    {
        { 0,0},
        { 1,11},
        { 2,24},
        { 3,39},
        { 4,58},
        { 5,80},
        { 40,18_103}

    };

    public static Dictionary<int, ulong> ProductionValuesForSolarPlant = new()
    {
         { 0,0},
        { 1,11},
        { 2,24},
        { 3,39},
        { 4,58},
        { 5,80},
        { 40,18_103}
    };
    public static Dictionary<int, ulong> ProductionValuesForFusionReactor= new()
    {
         { 0,0},
        { 1,10},
        { 2,20},
        { 3,30},
        { 4,40},
        { 5,50},
        { 40,400}
    };

}
