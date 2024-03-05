using System.Numerics;

namespace StarWarsPlanetsStats;

internal class StarWarsPlanetStatsApp
{
    private readonly IPlanetsReader _planetsApiDataReader;

    public StarWarsPlanetStatsApp(IPlanetsReader planetsApiDataReader)
    {
        _planetsApiDataReader = planetsApiDataReader;
    }

    public async Task Run()
    {
        var planets = await _planetsApiDataReader.Read();
        
        void Show(IEnumerable<Planet> planets) => TablePrinter.Print(planets);
            Show(planets);

        var propertyNamesToSelectorsMapping = new Dictionary<string, Func<Planet, long?>>
        {
            ["population"] = planet => planet.Population,
            ["diameter"] = planet => planet.Diameter,
            ["surface water"] = planet => planet.SurfaceWater,
        };

        Console.WriteLine();
        Console.WriteLine(
            "The statistics of which property would you " +
            "like to see?");
        Console.WriteLine(string.Join(Environment.NewLine,
            propertyNamesToSelectorsMapping.Keys));


        var userChoice = Console.ReadLine();

        if (userChoice is null ||
            !propertyNamesToSelectorsMapping.ContainsKey(userChoice))
        {
            Console.WriteLine("Invalid choice.");
        }
        else
        {
            ShowStatistics(planets, userChoice, propertyNamesToSelectorsMapping[userChoice]);
        }

    }

    private void ShowStatistics(
        IEnumerable<Planet> planets,
        string propertyName,
        Func<Planet, long?> propertySelector)
    {
        var planetWithMaxPropertyValue = planets.MaxBy(propertySelector);

        Console.WriteLine($"Max {propertyName} is: " +
            $"{planetWithMaxPropertyValue.Population} " +
            $"{planetWithMaxPropertyValue.Name}");

        var planetWithMinPropertyValue = planets.MinBy(propertySelector);

        Console.WriteLine($"Min {propertyName} is: " +
            $"{planetWithMinPropertyValue.Population} " +
            $"{planetWithMinPropertyValue.Name}");
    }

}
