namespace CookiesCookbook.Recipes.Ingredients
{
    public class Chocolate : Ingredient
    {
        public override string Name => "Chocolate";
        public override string PreparationInstructions => $"Melt in a water bath. {base.PreparationInstructions}.";
        public override int Id => 4;
    }
}
