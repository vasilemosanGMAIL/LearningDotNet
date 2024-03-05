using LearningGenerics.CustomCache;
using System.Runtime.InteropServices;

namespace LearningGenerics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //non generic list of ints
            var numbers = new ListOfInts();
            numbers.Add(10);
            numbers.Add(20);
            numbers.Add(30);
            numbers.Add(40);
            numbers.Add(50);

            numbers.RemoveAt(2);

            //Generic list implementation
            var nums = new SimpleList<int>();
            nums.Add(10);
            nums.Add(20);
            nums.Add(30);
            nums.RemoveAt(2);

            var words = new SimpleList<string>();
            words.Add("aa");
            words.Add("bb");
            words.RemoveAt(1);

            //exercise
            var pairOfInts = new Exercise31<string>("a", "b");
            Console.WriteLine("first is " + pairOfInts.First);
            Console.WriteLine("second is " + pairOfInts.Second);
            pairOfInts.ResetFirst();

            //implementation without tuples
            var list = new List<int> { 5, 3, 2, 8, 16, 7 };
            TwoInts minAndMax = GetMinAndMax(list);
            Console.WriteLine($"Smallest number is {minAndMax.Int1}");
            Console.WriteLine($"Largest number is {minAndMax.Int2}");

            TwoInts GetMinAndMax(IEnumerable<int> input)
            {
                if (!input.Any())
                {

                    throw new InvalidOperationException(
                        $"The input collection cannot be empty");
                }

                int min = input.First();
                int max = input.First();

                foreach (var number in input)
                {
                    if (number > max) max = number;
                    if (number < min) min = number;
                }

                return new TwoInts(min, max);
            }
            Console.WriteLine("/////////// Tuples ///////////");
            //generic implementation and with tuples
            SimpleTuple<int, int> minAndMax2 = GetMinAndMaxTuple(list);
            Console.WriteLine($"Smallest number is {minAndMax2.Item1}");
            Console.WriteLine($"Largest number is {minAndMax2.Item2}");
            //using with strings
            var twoStrings = new SimpleTuple<string, string>("aaa", "bbb");
            //using tuples
            var threeItems = new Tuple<string, int, bool>("aaa", 1, false);

            SimpleTuple<int, int> GetMinAndMaxTuple(IEnumerable<int> input)
            {
                if (!input.Any())
                {

                    throw new InvalidOperationException(
                        $"The input collection cannot be empty");
                }

                int min = input.First();
                int max = input.First();

                foreach (var number in input)
                {
                    if (number > max) max = number;
                    if (number < min) min = number;
                }

                return new SimpleTuple<int, int>(min, max);
            }
            //
            var john = new Person { Name = "John", YearOfBirth = 1980 };
            var anna = new Person { Name = "Anna", YearOfBirth = 1915 };

            void PrintInOrder(int first, int second)
            {

                if (first > second) { Console.WriteLine($"{second} {first}"); }
            }
            ///
            Console.WriteLine($"Square of 2 is: {Calculator.Square(2)}");
            Console.WriteLine($"Square of 4m is: {Calculator.Square(4m)}");
            Console.WriteLine($"Square of 6d is: {Calculator.Square(6d)}");

            ///Functions and Actions
            Console.WriteLine("/////////// Functions and Actions ///////////");
            Func<int, bool> predicate1 = IsLargerThan10;
            Func<int, bool> predicate2 = IsEven;

            var number = new[] { 1, 4, 7, 19, 2 };

            Console.WriteLine("IsLargerThan10 " + IsAny(number, predicate1));
            Console.WriteLine("IsEven " + IsAny(number, predicate2));

            bool IsLargerThan10(int number)
            {
                return number > 10;
            }

            bool IsEven(int number) 
            {
                return number % 2 == 0;
            }

            bool IsAny(IEnumerable<int> input,
                Func<int, bool> predicate)
            {

                foreach (var number in input)
                {
                    if (predicate(number)) return true;
                }
                return false;
            }

            //implementation with lambda expression
            Console.WriteLine("implementation with lambda expression");
            Console.WriteLine("IsLargerThan10 " + IsAny(number, n => n > 10));
            Console.WriteLine("IsEven " + IsAny(number, n => n % 2 == 0));
            ///Delegates
            ///
            Console.WriteLine("\\\\\\\\\\ Delegates ///////////");
            Delegates.Run();
            ///Dictionary 
            Console.WriteLine("\\\\\\\\\\ Dictionary ///////////");
            var countryToCurrencyMapping = new Dictionary<string, string>
            {
                ["Italy"] = "EUR",
                ["Moldova"] = "MDL"
            };
            countryToCurrencyMapping.Add("USA", "USD");
            countryToCurrencyMapping.Add("India", "INR");
            countryToCurrencyMapping.Add("Spain", "EUR");
            //Data in Dictionary is accessible via indexers and should be unique
            Console.WriteLine($"Currency is Spain is {countryToCurrencyMapping["Spain"]}");
            foreach (var country in countryToCurrencyMapping) 
                    { Console.WriteLine($"Key: {country.Key}, Value: {country.Value}"); }
            ///Strategy design pattern
            ///
            Console.WriteLine("\\\\\\\\\\ Strategy design pattern ///////////");
            var numbers1 = new List<int>() {10, 12, -100, 55, 17, 22 };
            var filteringSrategySelector = new FilteringStrategySelector();

            void Print<T>(IEnumerable<T> items)
            {
                Console.WriteLine(string.Join(",", items));
            }

            Console.WriteLine(@"Select filter:");
            Console.WriteLine(string.Join
                (Environment.NewLine, filteringSrategySelector.FilterStrategyNames));

            var userInput = Console.ReadLine();
            var filteringStrategy = new FilteringStrategySelector().Select(userInput);
            var result = new Filter().FilterBy(filteringStrategy, numbers1);


            Print(result);

            var words1 = new[] { "zebra", "ostrich", "otter" };
            var oWords1 = new Filter().FilterBy(word => word.StartsWith("o"), words1);
            Print(oWords1);

            Console.WriteLine("\\\\\\\\\\ Custom cache ///////////");

            IDataDownloader dataDownloader = new CachingDataDownloader(
                new PrintingDataDownloader(
                    new SlowDataDownloader()));
            Console.WriteLine(dataDownloader.DownloadData("id1"));
            Console.WriteLine(dataDownloader.DownloadData("id2"));
            Console.WriteLine(dataDownloader.DownloadData("id3"));
            Console.WriteLine(dataDownloader.DownloadData("id1"));
            Console.WriteLine(dataDownloader.DownloadData("id3"));
            Console.WriteLine(dataDownloader.DownloadData("id2"));

            

            Console.ReadKey();

        }
    }
}
