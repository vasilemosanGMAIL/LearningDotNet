
namespace GameDataParser
{
    public interface IDeserializeGame
    {
        List<VideoGame> DeserializeVideGameFrom(string fileName, string fileContents);
    }
}