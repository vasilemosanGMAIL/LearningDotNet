namespace LearningLINQ
{
    internal class Exercise39
    {
        public static string FindShortestWord(List<string> words)
        {
            if (words.Count == 0)
            {
                throw new Exception("Collection is empty");
            }

            string shortestWord = words
                .OrderBy(word => word.Length)
                .First();

            return shortestWord;
        }
    }
}
/*Implement the FindShortestWord method, which finds the shortest words in a collection of strings.
 * If more than one word has the same minimal length, the first one on order should be returned.

For example:
For words {"aaa", "b", "c", "dd"}, the result shall be "b" because it is the shortest (only 1 letter) and is before another word with the same length ("c")
For an empty collection, an exception should be thrown*/