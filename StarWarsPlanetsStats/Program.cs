namespace StarWarsPlanetsStats
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Star Wars Planets Stats!");
            try
            {
                await new StarWarsPlanetStatsApp(
                    new PlanetsFromApiReader(
                        new ApiDataReader(),
                        new MockStarWarsApiDataReader()
                        )).Run();
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred. "+ 
                    "Exception message: " + ex.Message);
            }

            Console.ReadKey();
        }
    }
}
