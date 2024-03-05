namespace LearningGenerics
{
    internal class Exercise36
    {
        public static Dictionary<PetType, double> FindMaxWeights(List<Pet> pets)
        {
            // Group the pets by PetType and get the maximum weight for each type
            var maxWeights = pets.GroupBy(p => p.PetType)
                                 .ToDictionary(g => g.Key, g => g.Max(p => p.Weight));

            return maxWeights;
        }
    }

    public class Pet
    {
        public PetType PetType { get; }
        public double Weight { get; }

        public Pet(PetType petType, double weight)
        {
            PetType = petType;
            Weight = weight;
        }

        public override string ToString() => $"{PetType}, {Weight} kilos";
    }

    public enum PetType { Dog, Cat, Fish }
}
