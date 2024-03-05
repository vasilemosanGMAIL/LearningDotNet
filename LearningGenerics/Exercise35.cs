namespace LearningGenerics
{
    internal class Exercise35
    {
        public Func<string, int> GetLenght = sentence => sentence.Length;//stores a function taking a string and returning its length.
        public Func<int> GetRandomNumberBetween1And10 = () => new Random().Next(1,11);//stores a parameterless function generating
                                                                                      //a random number between 1 and 10.
    }
}
