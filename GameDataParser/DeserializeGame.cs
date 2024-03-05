using System.Text.Json;

namespace GameDataParser
{
    public class DeserializeGame : IDeserializeGame
    {
        private readonly IUserInteractor _userInteractor;

        public DeserializeGame(IUserInteractor userInteractor)
        {
            _userInteractor = userInteractor;
        }

        public List<VideoGame> DeserializeVideGameFrom(string fileName, string fileContents)
        {
            try
            {
                return JsonSerializer.Deserialize<List<VideoGame>>(fileContents);
            }
            catch (JsonException ex)
            {
                _userInteractor.PrintError($"JSON in {fileName} file was not" +
                    $"in a valid format. JSON body:");
                _userInteractor.PrintError(fileContents);
                throw new JsonException($"{ex.Message} The file is: {fileName}", ex);
            }
        }
    }
}
