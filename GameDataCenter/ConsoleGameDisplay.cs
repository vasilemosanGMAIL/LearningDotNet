namespace GameDataCenter
{
    public class ConsoleGameDisplay : IConsoleGameDisplay
    {
        public void DisplayGames(List<GameModel> games)
        {
            foreach (var game in games)
            {
                Console.WriteLine(game);
            }
        }
    }
}
