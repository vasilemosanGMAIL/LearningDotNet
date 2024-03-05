namespace LearningGenerics
{
    public class Filter
    {
        public IEnumerable<T> FilterBy<T>(
            Func<T, bool> predicate, IEnumerable<T> numbers)
        {
            var result = new List<T>();
            foreach (var item in numbers)
            {
                if(predicate(item)) result.Add(item);
            }
            return result;
            //Implementation without delegate
            //switch (filteringType)
            //{
            //    case "Even":
            //        return Select(numbers, number => number %2 == 0);
            //    case "Odd":
            //        return Select(numbers, number => number % 2 != 0);
            //    case "Positive":
            //        return Select(numbers, number => number > 0);
            //    default:
            //        throw new NotSupportedException($"{filteringType} is not a valid filter");
            //}
        }

        //private List<int> Select(List<int> numbers, Func<int, bool> predicate)
        //{
        //    var result = new List<int>();
        //    foreach (var number in numbers)
        //    {
        //        if(predicate(number)) result.Add(number);
        //    }
        //    return result;
        //}

//Implementation without delegate
        //private List<int> SelectEven(List<int> numbers)
        //{
        //    var result = new List<int>();
        //    foreach (var number in numbers)
        //    {
        //        if (number % 2 == 0) result.Add(number);
        //    }
        //    return result;
        //}

        //private List<int> SelectOdd(List<int> numbers)
        //{
        //    var result = new List<int>();
        //    foreach (var number in numbers)
        //    {
        //        if (number % 2 != 0) result.Add(number);
        //    }
        //    return result;
        //}

        //private List<int> SelectPositive(List<int> numbers)
        //{
        //    var result = new List<int>();
        //    foreach (var number in numbers)
        //    {
        //        if (number > 0) result.Add(number);
        //    }
        //    return result;
        //}

    }
}
