using StarWarsPlanetsStats.DTO;

namespace StarWarsPlanetsStats;

internal readonly record struct Planet
{
    public string Name { get; }
    public long Diameter { get; }
    public long? SurfaceWater { get; }
    public long? Population { get; }

    public Planet(string name,
        long diameter,
        long? surfaceWater,
        long? population)
    {
        if(name is null) 
            throw new ArgumentNullException(nameof(name));

        Name = name;
        Diameter = diameter;
        SurfaceWater = surfaceWater;
        Population = population;
    }

    public static explicit operator Planet(Result planetDto)
    {
        var name = planetDto.name;
        var diameter = long.Parse(planetDto.diameter);

        long? population = StringExtensions.ToIntOrNull(planetDto.population);
        long? surfaceWater = StringExtensions.ToIntOrNull(planetDto.surface_water);

        return new Planet(name, diameter, population, surfaceWater);
    }

}