
using StarWarsPlanetsStats.DTO;
using System.Text.Json;

namespace StarWarsPlanetsStats;

internal class PlanetsFromApiReader : IPlanetsReader
{
    private readonly IApiDataReader _apiDataReader;
    private readonly IApiDataReader _secondaryApiDataReader;

    public PlanetsFromApiReader(IApiDataReader apiDataReader,
        IApiDataReader secondaryApiDataReader)
    {
        _apiDataReader = apiDataReader;
        _secondaryApiDataReader = secondaryApiDataReader;
    }

    public async Task<IEnumerable<Planet>> Read()
    {
        string? json = null;
        try
        {
            json = await _apiDataReader.Read("https://swapi.dev", "/api/planets");
        }
        catch (HttpRequestException ex)
        {
            await Console.Out.WriteLineAsync("API request was unsuccessful. " +
                "Switching to mock data. " +
                "Exception message: " + ex.Message);
        }

        json ??= await _secondaryApiDataReader.Read("https://swapi.dev", "/api/planets");
        var root = JsonSerializer.Deserialize<Root>(json);
        return ToPlanets(root);
    }

    private IEnumerable<Planet> ToPlanets(Root? root)
    {
        ArgumentNullException.ThrowIfNull(root);

        var planets = new List<Planet>();

        foreach (var planetDto in root.results)
        {
            Planet planet = (Planet)planetDto;
            planets.Add(planet);
        }
        return planets;
    }
}
