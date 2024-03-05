using System.Text.Json;

namespace GameDataCenter
{
    public class JsonReader : IJsonReader
    {
        public List<GameModel> ReadJson(string jsonFilePath)
        {
            try
            {
                string json = File.ReadAllText(jsonFilePath);
                return JsonSerializer.Deserialize<List<GameModel>>(json);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading JSON file: {ex.Message}");
                return new List<GameModel>();
            }
        }
    }
}
