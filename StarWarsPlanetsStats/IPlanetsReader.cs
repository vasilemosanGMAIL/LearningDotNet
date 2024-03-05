using StarWarsPlanetsStats;

internal interface IPlanetsReader
{
    Task<IEnumerable<Planet>> Read();
}
