namespace GameDataParser
{
    public partial class GameDataParserApp
    {
        public interface IFileReader{
            string Read(string fileName);
        }

    }
}
