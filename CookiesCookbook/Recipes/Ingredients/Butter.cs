namespace CookiesCookbook.Recipes.Ingredients
{
    public class Butter : Ingredient
    {
        public override string Name => "Butter";
        public override string PreparationInstructions => $"Melt in a water bath. {base.PreparationInstructions}.";
        public override int Id => 3;
    }
}
