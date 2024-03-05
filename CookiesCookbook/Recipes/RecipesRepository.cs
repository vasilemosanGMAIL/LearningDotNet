using CookiesCookbook.DataAccess;
using CookiesCookbook.Recipes.Ingredients;

namespace CookiesCookbook.Recipes
{
    public class RecipesRepository : IRecipesRepository
    {
        private readonly IStringsRepository _stringsRepository;
        private readonly IIngredientsRegister _ingredientsRegister;

        public RecipesRepository(IStringsRepository stringsRepository, IIngredientsRegister ingredientsRegister)
        {
            _stringsRepository = stringsRepository;
            _ingredientsRegister = ingredientsRegister;
        }

        //OLD implementation of Read
        //public List<Recipe> Read(string filePath)
        //{
        //    var recipesFromFile = _stringsRepository.Read(filePath);
        //    var recipes = new List<Recipe>();

        //    foreach (var recipeFromFile in recipesFromFile)
        //    {
        //        var recipe = RecipeFromString(recipeFromFile);
        //        recipes.Add(recipe);
        //    }
        //    return recipes;
        //}

        //LINQ implementation of Read
        public List<Recipe> Read(string filePath)
        {
            return _stringsRepository.Read(filePath)
                   .Select(RecipeFromString)
                   .ToList();
        }

        private Recipe RecipeFromString(string recipeFromFile)
        {
            var ingredients = recipeFromFile.Split(',')
                .Select(int.Parse)
                .Select(_ingredientsRegister.GetById);

            return new Recipe(ingredients);
        }

        public void Write(string filePath, List<Recipe> allRecipes)
        {
            var recipesAsStrings = allRecipes
                .Select(recipe =>
                {
                    return (string.Join(",", recipe.Ingredients.Select(ingredient => ingredient.Id)));
                });

            _stringsRepository.Write(filePath, recipesAsStrings.ToList());
        }
    }
}
