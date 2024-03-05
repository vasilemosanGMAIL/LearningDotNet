using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace GameDataCenter
{
    public class App
    {
        private readonly IJsonReader _reader;
        private readonly IConsoleGameDisplay  _gameDisplay;
        private List<GameModel> games = new List<GameModel>(); 

        public App(IJsonReader reader, IConsoleGameDisplay gameDisplay)
        {
            _reader = reader;
            _gameDisplay = gameDisplay;
        }

        public void Run()
        {
            Console.WriteLine("Enter the name of the file you want to read:\n");
            bool shallStop = false;

            while(!shallStop)
            {
                string fileName = Console.ReadLine();

                if (fileName is null) { Console.WriteLine("The input should not be null"); continue; }
                if (!File.Exists(fileName))
                {
                    Console.WriteLine("File does not exist. Provide a correct file name.");
                    continue;
                }
                {
                    Console.WriteLine(fileName + " Exists");
                    games = _reader.ReadJson(fileName);
                    Console.WriteLine();
                    _gameDisplay.DisplayGames(games);

                    shallStop = true;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Press any key to close application");
            Console.ReadLine();

        }

    }
}
