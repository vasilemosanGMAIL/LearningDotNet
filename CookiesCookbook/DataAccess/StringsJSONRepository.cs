using System.Text.Json;

namespace CookiesCookbook.DataAccess
{
    public class StringsJSONRepository : IStringsRepository
    {
        public List<string> Read(string filepath)
        {
            if (File.Exists(filepath))
            {
                var fileContents = File.ReadAllText(filepath);
                return JsonSerializer.Deserialize<List<string>>(fileContents);
            }
            return new List<string>();
        }

        public void Write(string filepath, List<string> strings)
        {
            File.WriteAllText(filepath, JsonSerializer.Serialize(strings));
        }
    }
}
