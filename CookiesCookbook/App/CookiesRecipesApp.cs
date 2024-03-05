using CookiesCookbook.Recipes;

namespace CookiesCookbook.App
{
    public class CookiesRecipesApp
    {
        private readonly IRecipesRepository _recipesRepository;
        private readonly IRecipiesConsoleUserInteraction _recipiesConsoleUserInteraction;

        public CookiesRecipesApp(IRecipesRepository recipesRepository, IRecipiesConsoleUserInteraction recipiesUserInteraction)
        {
            _recipesRepository = recipesRepository;
            _recipiesConsoleUserInteraction = recipiesUserInteraction;
        }
        public void Run(string filePath)
        {
            var allRecipes = _recipesRepository.Read(filePath);
            _recipiesConsoleUserInteraction.PrintExistingrecipes(allRecipes);

            _recipiesConsoleUserInteraction.PromptToCreateRecipes();

            var ingredients = _recipiesConsoleUserInteraction.ReadIngredientsFromUser();

            if (ingredients.Count() > 0)
            {
                var recipe = new Recipe(ingredients);
                allRecipes.Add(recipe);
                _recipesRepository.Write(filePath, allRecipes);

                _recipiesConsoleUserInteraction.ShowMessage("Recipe added:");
                _recipiesConsoleUserInteraction.ShowMessage(recipe.ToString());
            }
            else
            {
                _recipiesConsoleUserInteraction.ShowMessage("No ingredients have been selected." +
                    "Recipe will not be saved.");
            }

            _recipiesConsoleUserInteraction.Exit();
        }
    }
}
