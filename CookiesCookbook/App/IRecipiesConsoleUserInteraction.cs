using CookiesCookbook.Recipes;
using CookiesCookbook.Recipes.Ingredients;

namespace CookiesCookbook.App
{
    public interface IRecipiesConsoleUserInteraction
    {
        void ShowMessage(string message);
        void Exit();
        void PrintExistingrecipes(IEnumerable<Recipe> allRecipes);
        void PromptToCreateRecipes();
        IEnumerable<Ingredient> ReadIngredientsFromUser();
    }
}
