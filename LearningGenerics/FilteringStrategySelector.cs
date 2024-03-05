﻿namespace LearningGenerics
{
    internal class FilteringStrategySelector
    {
        private readonly Dictionary<string, Func<int, bool>> _filteringStrategies = new Dictionary<string, Func<int, bool>>
        {
            ["Even"] = number => number % 2 == 0,
            ["Odd"] = number => number % 2 == 1,
            ["Positive"] = number => number > 0,
            ["Negative"] = number => number < 0,
        };

        public IEnumerable<string> FilterStrategyNames =>
            _filteringStrategies.Keys;

        public Func<int, bool> Select(string filteringType)
        {
            if (!_filteringStrategies.ContainsKey(filteringType)) 
                throw new NotSupportedException($"{filteringType} is not a valid filter");

            return _filteringStrategies[filteringType];
            //Implementation without Dictionary
            //switch (filteringType)
            //{
            //    case "Even":
            //        return  number => number % 2 == 0;
            //    case "Odd":
            //        return number => number % 2 == 1;
            //    case "Positive":
            //        return number => number > 0;
            //    default:
            //        throw new NotSupportedException($"{filteringType} is not a valid filter");
            //}
        }
    }
}
