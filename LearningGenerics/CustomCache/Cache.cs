﻿namespace LearningGenerics.CustomCache
{
    internal class Cache<TKey, TData>
    {
        private readonly Dictionary<TKey, TData> _cachedData = new();

        public TData Get(TKey key, Func<TKey, TData> getForTheFirstTime)
        {
            if (!_cachedData.ContainsKey(key)) 
            {

                _cachedData[key] = getForTheFirstTime(key);
            }
            return _cachedData[key];
        }
    }
}
