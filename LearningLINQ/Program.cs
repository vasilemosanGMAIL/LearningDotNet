using System.Globalization;

namespace LearningLINQ
{
    internal partial class Program
    {
        static void Main(string[] args)
        {

            var wordsNoUppercase = new string[]
            {
                "quick", "brown", "fox"
            };
            Console.WriteLine(IsAnyWordUpperCase(wordsNoUppercase));

            var wordsUppercase = new string[]
            {
                "quick", "brown", "FOX"
            };
            Console.WriteLine(IsAnyWordUpperCase(wordsUppercase));

            Console.WriteLine($"Linq implementation: {IsAnyWordUpperCase_Linq(wordsNoUppercase)}");
            Console.WriteLine($"Linq implementation: {IsAnyWordUpperCase_Linq(wordsUppercase)}");

            
            var numbers = new[] { 1, 4, 7, 19, 2 };
            var words = new[] { "lion", "tiger", "snow leopard" };
            //LINQ 2 options of writting code
            //Method syntax
            var evenNumber = numbers.Where(n => n % 2 == 0);
            //Query syntax
            var evenNumber2 = from number in numbers
                              where number % 2 == 0
                              select number;

            //Contains
            bool isTigerPresent = words.Contains("tiger");
            Console.WriteLine(nameof(isTigerPresent) + ": " + isTigerPresent);

            //First and Last
            var firstOdd = numbers.First(number => number % 2 != 1);
            Console.WriteLine(nameof(firstOdd) + ": " + firstOdd);

            //Average. Anonymous types
            var listOfNumbers = new List<List<int>>
            {
                new() {15, 68, 20, 12, 19, 8, 55},
                new() {12, 1, 3, 4, -19, 8, 7, 6},
                new() {5, -6, -2, -12, -10, 7},
            };

            //var result = listOfNumbers.
            //    Select(listOfNumber => new CountAndAverage
            //    {
            //        Count = listOfNumber.Count(),
            //        Average = listOfNumber.Average()
            //    })
            //    .OrderByDescending(countAndAverage => countAndAverage.Average)
            //    .Select(countAndAverage => 
            //        $"Count is: {countAndAverage.Count}, " +
            //        $"Average is: {countAndAverage.Average}");

            // Above example implemented with Tuples
            //var result = listOfNumbers.
            //    Select(listOfNumber => new Tuple<int, double>
            //    (
            //        listOfNumber.Count(),
            //        listOfNumber.Average()
            //    ))
            //    .OrderByDescending(countAndAverage => countAndAverage.Item2)
            //    .Select(countAndAverage =>
            //        $"Count is: {countAndAverage.Item1}, " +
            //        $"Average is: {countAndAverage.Item2}");

            // Above example implemented with anonimous types
            var result = listOfNumbers.
                Select(listOfNumber => new //here we created an anonimous type with 2 properties
                    {
                        Count = listOfNumber.Count(),
                        Average = listOfNumber.Average()
                    })
                .OrderByDescending(countAndAverage => countAndAverage.Average)
                .Select(countAndAverage =>
                    $"Count is: {countAndAverage.Count}, " +
                    $"Average is: {countAndAverage.Average}");

            Console.WriteLine(string.Join(Environment.NewLine, result));

            
            Console.ReadKey();
        }


        //No linq implementation
        public static bool IsAnyWordUpperCase(IEnumerable<string> words)
        {
            foreach (var word in words)
            {
                bool areAllUpperCase = true;
                foreach (var letter in word)
                {
                    if (char.IsLower(letter)) areAllUpperCase = false;
                }
                if (areAllUpperCase) return true;
            }
            return false;
        }
        //linq implementation
        public static bool IsAnyWordUpperCase_Linq(IEnumerable<string> words)
        {
            return words.Any(word =>
            word.All(letter => char.IsUpper(letter)));
        }


    }
}
