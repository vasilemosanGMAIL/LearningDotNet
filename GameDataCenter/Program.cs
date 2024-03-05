namespace GameDataCenter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var app = new App(new JsonReader(), new ConsoleGameDisplay());
            app.Run();

        }
    }
}
