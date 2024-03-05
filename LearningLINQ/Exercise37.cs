namespace LearningLINQ
{
    internal class Exercise37
    {
        //method syntax
        public static bool IsAnyWordWhiteSpace(List<string> words)  => 
            words.Any(word => word.All(
                charater =>char.IsWhiteSpace(charater)));

        //querry syntax
        public static bool IsAnyWordWhiteSpace_querySyntax(List<string> words)
        {
            bool result = (
                from word in words
                where word.All(character => char.IsWhiteSpace(character))
                select word
            ).Any();

            return result;
        }
    }
}
