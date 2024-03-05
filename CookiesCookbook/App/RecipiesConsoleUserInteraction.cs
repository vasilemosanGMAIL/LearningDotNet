using CookiesCookbook.Recipes;
using CookiesCookbook.Recipes.Ingredients;
using System.Diagnostics.Metrics;

namespace CookiesCookbook.App
{
    public class RecipiesConsoleUserInteraction : IRecipiesConsoleUserInteraction
    {
        private readonly IngredientsRegister _ingredientsRegister;

        public RecipiesConsoleUserInteraction(IngredientsRegister ingredientsRegister)
        {
            _ingredientsRegister = ingredientsRegister;
        }

        public void Exit()
        {
            Console.WriteLine("Press any key to close.");
            Console.ReadKey();
        }

        public void PrintExistingrecipes(IEnumerable<Recipe> allRecipes)
        {
            if (allRecipes.Count() > 0)
            {
                Console.WriteLine("Existing recipes are: " + Environment.NewLine);


                //var counter = 1;
                //foreach (var recipe in allRecipes)
                //{
                //    Console.WriteLine($"****{counter}****");
                //    Console.WriteLine(recipe);
                //    Console.WriteLine();
                //    ++counter;
                //}
                var allRecipesAsstrings = allRecipes
                .Select((recipe, index) =>
$@"****{index + 1}****
{recipe}");

                Console.WriteLine(
                    string.Join(Environment.NewLine, allRecipesAsstrings));
                Console.WriteLine();
            }

        }

        public void PromptToCreateRecipes()
        {
            Console.WriteLine("Create a new cookies recipe! " +
                "Available ingredients are:");

            //foreach (var ingredient in _ingredientsRegister.All)
            //{
            //    Console.WriteLine(ingredient);
            //}
            Console.WriteLine(
                string.Join(Environment.NewLine, _ingredientsRegister.All));
        }

        public IEnumerable<Ingredient> ReadIngredientsFromUser()
        {
            bool shallStop = false;
            var ingredients = new List<Ingredient>();

            while (!shallStop)
            {
                Console.WriteLine("Add an ingredient by its ID, " + "or type anything else if finished");

                var userInput = Console.ReadLine();


                if (int.TryParse(userInput, out int id))
                {
                    var selectedIngredient = _ingredientsRegister.GetById(id);

                    if (selectedIngredient is not null)
                    {
                        ingredients.Add(selectedIngredient);
                    }
                }
                else
                {
                    shallStop = true;
                }
            }

            return ingredients;
        }

        public void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
