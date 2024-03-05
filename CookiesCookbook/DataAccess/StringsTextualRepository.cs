namespace CookiesCookbook.DataAccess
{
    public class StringsTextualRepository : IStringsRepository
    {
        private static readonly string Separator = Environment.NewLine;

        public List<string> Read(string filepath)
        {
            if (File.Exists(filepath))
            {
                var fileContents = File.ReadAllText(filepath);
                return fileContents.Split(Separator).ToList();
            }
            return new List<string>();
        }

        public void Write(string filepath, List<string> strings)
        {
            File.WriteAllText(filepath, string.Join(Separator, strings));
        }
    }
}
