namespace GameDataCenter
{
    public interface IJsonReader
    {
        List<GameModel> ReadJson(string jsonFilePath);
    }
}
