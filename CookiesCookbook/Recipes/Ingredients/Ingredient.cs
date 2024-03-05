﻿namespace CookiesCookbook.Recipes.Ingredients
{
    public abstract class Ingredient
    {
        public abstract string Name { get; }
        public abstract int Id { get; }
        public virtual string PreparationInstructions => "Add to other ingredients";

        public override string ToString() => $"{Id}. {Name}.";

    }
}
