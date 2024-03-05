namespace CookiesCookbook.Recipes.Ingredients
{
    public class IngredientsRegister : IIngredientsRegister
    {
        public IEnumerable<Ingredient> All { get; } = new List<Ingredient>
        {
            new WheatFlour(),
            new SpeltFlour(),
            new Butter(),
            new Cardamon(),
            new Cinnamon(),
            new Chocolate(),
        };

        public Ingredient GetById(int id)
        {
            var allIngredientsWithGivenId = All.Where(
                ingredient => ingredient.Id == id);

            if (allIngredientsWithGivenId.Count() > 1)
            {
                throw new InvalidOperationException(
                    $"More than one ingredients have ID equal to {id}");
            }

            return allIngredientsWithGivenId.FirstOrDefault();
        }
    }
}
