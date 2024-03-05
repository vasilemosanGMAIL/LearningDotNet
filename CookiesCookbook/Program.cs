
using CookiesCookbook.DataAccess;
using CookiesCookbook.FileAccess;
using CookiesCookbook.Recipes;
using CookiesCookbook.Recipes.Ingredients;
using CookiesCookbook.App;

namespace CookiesCookbook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CookiesCookbook!");

            const FileFormat format = FileFormat.Json;

            IStringsRepository stringsRepository = format == FileFormat.Json ?
                new StringsJSONRepository() : new StringsTextualRepository();

            const string FileName = "recipes";
            var fileMetadata = new FileMetadata(FileName, format);

            var ingredientsRegister = new IngredientsRegister();

            var cookiesRecipesApp = new CookiesRecipesApp(
                new RecipesRepository(
                stringsRepository,
                ingredientsRegister),
                new RecipiesConsoleUserInteraction(
                ingredientsRegister));

            cookiesRecipesApp.Run(fileMetadata.ToPath());
        }
    }
}
