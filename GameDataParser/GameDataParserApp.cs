using System.Text.Json;

namespace GameDataParser
{
    public partial class GameDataParserApp
    {
        private readonly IUserInteractor _userInteractor;
        private readonly IGamesPrinter _gamesPrinter;
        private readonly IDeserializeGame _deserializeGame;
        private readonly IFileReader _reader;


        public GameDataParserApp(IUserInteractor userInteractor, IGamesPrinter gamesPrinter, IDeserializeGame deserializeGame, IFileReader reader)
        {
            _userInteractor = userInteractor;
            _gamesPrinter = gamesPrinter;
            _deserializeGame = deserializeGame;
            _reader = reader;
        }

        public void Run()
        {
            string fileName = _userInteractor.ReadValidPath();
            var fileContents = _reader.Read(fileName);
            List<VideoGame> videoGames = _deserializeGame.DeserializeVideGameFrom(fileName, fileContents);
            _gamesPrinter.Print(videoGames);
        }

    }
}
