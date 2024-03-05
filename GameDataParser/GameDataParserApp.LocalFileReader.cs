namespace GameDataParser
{
    public partial class GameDataParserApp
    {
        public class LocalFileReader : IFileReader
        {
            public string Read(string fileName)
            {
                return File.ReadAllText(fileName);
            }
        }

    }
}
