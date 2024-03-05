using System.Text.Json;
using static GameDataParser.GameDataParserApp;

namespace GameDataParser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var userInteractor = new ConsoleUserInteractor();
            var app = new GameDataParserApp(
                userInteractor,
                new GamesPrinter(userInteractor),
                new DeserializeGame(userInteractor),
                new LocalFileReader());
            var logger = new Logger("log.txt");

            try
            {
                app.Run();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Sorry! The application has experienced an unexpected error");
                logger.Log(ex);
            }

            Console.WriteLine("Press any key to close.");
            Console.ReadKey();

        }
    }
}
